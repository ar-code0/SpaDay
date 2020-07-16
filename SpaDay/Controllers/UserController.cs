using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]
        [Route("User/Add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("User/Add")]

        public IActionResult Add(User newUser, string verify)
        {

            if (newUser.Password != verify)
            {
                ViewBag.error = "Passwords don't match";
                ViewBag.email = newUser.Email;
                ViewBag.username = newUser.Username;
                return View("Add");
            }
            else
            {
                newUser.DateJoined = DateTime.Now;
                ViewBag.date = newUser.DateJoined.Date;
                ViewBag.email = newUser.Email;
                ViewBag.username = newUser.Username;
                return View("index");
            }
        }

    }
}
