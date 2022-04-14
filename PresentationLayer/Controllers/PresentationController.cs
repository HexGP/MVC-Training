using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogicLayer;

namespace PresentationLayer.Controllers
{
    public class PresentationController : Controller
    {
        // GET: Presentation
        public ActionResult Index()
        {

            return View();
        }
    }
}