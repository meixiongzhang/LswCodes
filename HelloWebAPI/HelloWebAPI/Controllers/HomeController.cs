﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {//aaaa
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
