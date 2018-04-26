using Base2BaseWeb.B2B.DataLayer.Entities;
using Base2BaseWeb.UI.Services;
using DbSyncService;
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
        private readonly IServiceScopeFactory _scopeFactory;
        private IOptions<ConnectionSettingsOptions> _connectionSettings;
        private IOptions<TimerSettings> _timerSettings;
        private readonly ILogger<TimedHostedService> _logger;
        private Timer _timer;
        private DbSyncWorker worker;

        public TimedHostedService(ILogger<TimedHostedService> logger, 
            IOptions<ConnectionSettingsOptions> connectionSettings,
            IOptions<TimerSettings> timerSettings,
            IServiceScopeFactory scopeFactory)
        {
            _connectionSettings = connectionSettings;
            _timerSettings = timerSettings;
            _logger = logger;
            _scopeFactory = scopeFactory;
            //_context = context;
        }
        //private void WorkerInitialize(DbSyncWorker worker)
        //{
        //    worker.SourceCredentialsList.Add(new Credentials
        //    {
        //        PointNumber = 182,
        //        GroupName= "Клиенты МХП - Рексіна О.О., ФОП",
        //        Server= "sql-001.base2base.com.ua,14332",
        //        Database= "REKSINA",
        //        User= "REKSINA-USER",
        //        Password= "5cHgk296OB"
        //    });
        //}

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

                worker = new DbSyncWorker(_connectionSettings.Value.B2BTest);
                foreach (var client in clients)
                {
                    if(client.ProductClients.Where(c => c.TovarNumber == 99).FirstOrDefault()!=null)
                    {
                        worker.SourceCredentialsList.Add(new Credentials
                        {
                            PointNumber = client.PointNumber,
                            GroupName = client.CliGroup.CliGroupName + " - " + client.NamePoint,
                            Server = client.ClientConnectionInfo.ServerName,
                            Database = client.ClientConnectionInfo.DatabaseName,
                            User = client.ClientConnectionInfo.Login,
                            Password = client.ClientConnectionInfo.PasswordHash
                        });
                    }
                }
                worker.SynchronizeTables();
                _logger.LogInformation($"Tables synchronized at {DateTime.Now}.");
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
