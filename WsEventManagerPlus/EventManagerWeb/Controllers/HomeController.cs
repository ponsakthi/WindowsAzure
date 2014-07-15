using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventManagerWorker;
using Microsoft.WindowsAzure.ServiceRuntime;

namespace EventManagerWeb.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Trace.WriteLine("Web Log");
            new WorkerLog().Log();
            ViewBag.Message = RoleEnvironment.GetConfigurationSettingValue("Greeting");
            return View();
        }

    }
}
