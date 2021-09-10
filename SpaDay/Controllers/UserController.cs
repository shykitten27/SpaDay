using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("spa/user/add")]
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            // add form submission handling code here
            if (ViewBag.password == ViewBag.verify)
            {
                ViewBag.username = newUser;
                return View("Index");
            }
            else 
            {
                return View();
            }
        }
    }
}
