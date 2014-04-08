using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlexFitnessCenter.DataAccess;
using FlexFitnessCenter.Entities;

namespace FlexFitnessCenter.Web.Controllers
{
    public class HomeController : BaseController

    {
        private readonly IRepository<GenericMember> _repository;

        public HomeController(IRepository<GenericMember> repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            var model= (List<GenericMember>) _repository.GetAll();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
