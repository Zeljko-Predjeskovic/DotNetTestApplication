using Microsoft.AspNetCore.Mvc;
using Pre.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pre.WebApplication.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View(new UserList());
        }
    }
}
