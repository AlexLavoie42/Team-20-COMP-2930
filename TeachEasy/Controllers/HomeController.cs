﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace TeachEasy.Controllers
{
    //[RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
       
            return View();
        }
    }
}
