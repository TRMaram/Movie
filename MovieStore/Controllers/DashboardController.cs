﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MovieStore23.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        
        public IActionResult Display()
        {
            return View();
        }
    }
}
