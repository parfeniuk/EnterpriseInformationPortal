using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;

namespace Base2BaseWeb.UI.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    public class EmailSender : IEmailSender
    {
        // IOptions instance of secret configurations via DI
        public EmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor)
        {
            Options = optionsAccessor.Value;
        }
        public AuthMessageSenderOptions Options { get; } //set only via Secret Manager

        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Execute(email,subject,message);
        }

        public async Task Execute(string email, string subject, string message)
        {
            // Instantiate MimeMessage object
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(Options.MailBoxSettings.MailboxName, Options.MailBoxSettings.MailboxAddress));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            // Send Mails async
            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(Options.SmtpSettings.Host, Options.SmtpSettings.Port, Options.SmtpSettings.Ssl);
                await client.AuthenticateAsync(Options.SmtpSettings.Username, Options.SmtpSettings.Password);
                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true);
            }
        }
    }
}
