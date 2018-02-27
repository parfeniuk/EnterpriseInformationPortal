using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Services
{
    public class AuthMessageSenderOptions
    {
        public MailBoxSettings MailBoxSettings { get; set; }
        public SmtpSettings SmtpSettings { get; set; }
    }

    public class MailBoxSettings
    {
        public string MailboxName { get; set; }
        public string MailboxAddress { get; set; }
    }

    public class SmtpSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public bool Ssl { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
