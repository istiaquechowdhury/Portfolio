﻿using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
