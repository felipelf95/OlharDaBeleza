using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OlharDaBeleza.Models;

namespace OlharDaBeleza.Controllers
{
    public class LoginController : Controller
    {
        
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View(Menu());
        }

       

        

        

    }
}