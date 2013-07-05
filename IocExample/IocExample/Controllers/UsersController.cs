using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IocExample
{
    public class UsersController : Controller
    {
        private readonly IRepository _repository;
        private readonly IEmailService _emailService;

        public UsersController(IRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;
        }

        public ActionResult Index()
        {
            //do something here
            return View();
        }

    }
}
