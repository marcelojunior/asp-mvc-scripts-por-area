using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Areas.Producao.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Producao/Home/
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Teste()
        {
            return View();
        }
	}
}