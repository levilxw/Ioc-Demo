using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;

namespace AspMvc.Controllers
{
    public class ValuesController : Controller
    {
        private ISend _send;

        public ValuesController(ISend send)
        {
            _send = send;
        }

        // GET: Values
        public ActionResult Index()
        {
            ViewBag.send1 = _send.GetGuid();

            return View();
        }
    }
}