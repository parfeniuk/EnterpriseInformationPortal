using Base2BaseWeb.B2B.DataLayer.Entities;
using Base2BaseWeb.UI.Services;
using DbSyncService;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RepositoryGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.DbSync
{
    internal class TimedHostedService : IHostedService, IDisposable
    {
        private IHostingEnvironment _environment;
        private readonly IServiceScopeFactory _scopeFactory;
        private IOptions<ConnectionSettingsOptions> _connectionSettings;
        private IOptions<TimerSettings> _timerSettings;
        private IOptions<InternalServerSettings> _serverSettings;
        private readonly ILogger<TimedHostedService> _logger;
        private readonly ILogger<DbSyncWorker> _loggerWorker;
        private Timer _timer;
        private DbSyncWorker worker;

        public TimedHostedService(ILogger<TimedHostedService> logger,
            ILogger<DbSyncWorker> loggerWorker,
            IOptions<ConnectionSettingsOptions> connectionSettings,
            IOptions<TimerSettings> timerSettings,
            IOptions<InternalServerSettings> serverSettings,
            IHostingEnvironment environment,
            IServiceScopeFactory scopeFactory)
        {
            _environment = environment;
            _connectionSettings = connectionSettings;
            _serverSettings = serverSettings;
            _timerSettings = timerSettings;
            _logger = logger;
            _loggerWorker = loggerWorker;
            _scopeFactory = scopeFactory;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Background Service is starting.");

            _timer = new Timer(DoWork, null, TimeSpan.FromSeconds(_timerSettings.Value.TimeStart),
                TimeSpan.FromSeconds(_timerSettings.Value.TimeInterval));

            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var _context = scope.ServiceProvider.GetRequiredService<IRepositoryContextBase>();
                var clients = _context.Set<Point>()
                    ?.GetAll()
                    ?.Include(c => c.CliGroup)
                    ?.Include(c => c.ClientConnectionInfo)
                    ?.Include(c=>c.ProductClients);

                worker = new DbSyncWorker(_connectionSettings.Value.B2B, _loggerWorker);
                foreach (var client in clients)
                {
                    if(client.ProductClients.Where(c => c.TovarNumber == 99).FirstOrDefault()!=null)
                    {
                        Credentials credentials = new Credentials
                        {
                            PointNumber = client.PointNumber,
                            PointName = client.NamePoint,
                            GroupName = client.CliGroup.CliGroupName + " - " + client.NamePoint,
                            Server = client.ClientConnectionInfo?.ServerName,
                            Database = client.ClientConnectionInfo?.DatabaseName,
                            User = client.ClientConnectionInfo?.Login,
                            Password = client.ClientConnectionInfo?.PasswordHash
                        };
                        // Define Server IP Address based on hosting environment
                        if (!_environment.IsDevelopment())
                        {
                            string port = credentials?.Server?.Split(',')[1];
                            credentials.Server = port == "14332" ?
                                _serverSettings.Value.InternalServerOne :
                                _serverSettings.Value.InternalServerTwo;
                        }
                        worker.SourceCredentialsList.Add(credentials);
                    }
                }
                if (worker.SourceCredentialsList.Count>0)
                {
                    worker.SynchronizeTables();
                }
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Background Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
