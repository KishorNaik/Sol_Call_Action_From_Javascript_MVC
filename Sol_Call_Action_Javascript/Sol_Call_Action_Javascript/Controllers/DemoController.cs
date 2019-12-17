using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_Call_Action_Javascript.Models;

namespace Sol_Call_Action_Javascript.Controllers
{
    public class DemoController : Controller
    {

        public DemoController()
        {
            Users = new UserModel();
        }


        [BindProperty]
        public UserModel Users { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OnGetJson()
        {
            Users.firstName = "Kishor";
            Users.lastName = "Naik";

            return base.Json(Users);
        }

        [HttpPost]
        public IActionResult OnPostJson([FromBody]UserModel userModel)
        {
            return base.Json(userModel);
        }
    }
}