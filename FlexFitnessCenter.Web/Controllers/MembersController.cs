using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlexFitnessCenter.Web.Controllers
{
    public class MembersController : BaseController
    {
        public MembersController()
        {
            
        }

        public ActionResult Index()
        {


            return View();
        }

    }
}
