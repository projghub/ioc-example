using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IocExample
{
    public class IEmailService { }
    public class EmailService : IEmailService
    {
        private readonly IEmailService _emailService;

        public EmailService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public bool Send()
        {
            throw new Exception("You must implement Send");
        }
    }
}