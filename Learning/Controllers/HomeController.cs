﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learning.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult MainPage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SecondPage()
        {
            return View();
        }
    }
}