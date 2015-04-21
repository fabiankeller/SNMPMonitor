﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SNMPMonitor.PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Monitor()
        {
            return View();
        }

        public ActionResult Logs()
        {
            return View();
        }

        public ActionResult AddAgent()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult SideBarContent()
        {
            return PartialView();
        }
    }
}