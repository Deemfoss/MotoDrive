﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MotoDrive.Web.Controllers
{
    public class AuthorisationController : Controller
    {
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(string name)
        {
            return View();
        }
    }
}