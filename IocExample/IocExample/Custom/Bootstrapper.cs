using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IocExample
{
    public static class BootStrapper
    {
        public static void Configure(IContainer container)
        {
            container.Register<UsersController, UsersController>();
            container.Register<IRepository, Repository>();
            container.Register<IEmailService, EmailService>();
        }
    }
}