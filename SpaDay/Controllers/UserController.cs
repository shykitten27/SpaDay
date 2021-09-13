﻿using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        [Route("spa/user/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("spa/user/add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            // add form submission handling code here
            if (newUser.Password == verify)
            {
                ViewBag.username = newUser.Username;
                /*ViewBag.password = newUser.Password;
                ViewBag.email = newUser.Email;*/ //not necessary 
                return View("Index"); //return to User/Index.cshtml
            }
            else
            {
                ViewBag.errormessage = "Passwords do not match. Please try again.";
                ViewBag.username = newUser.Username; //repopulate form
                ViewBag.email = newUser.Email;       //repopulate form
                return View("Add"); //return to Add.cshtml
            }
        }
    }
}