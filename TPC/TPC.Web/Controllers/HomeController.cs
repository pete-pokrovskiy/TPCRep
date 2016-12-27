using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPC.Web.Infrastructure.Filters;

namespace TPC.Web.Controllers
{
    
    public class HomeController : Controller
    {
        [UnderConstructionFilter]
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult UnderConstruction()
        {
            return View();
        }
    }
}