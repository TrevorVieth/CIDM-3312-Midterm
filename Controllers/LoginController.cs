using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MidtermVieth.Models;

namespace MidtermVieth.Controllers
{
    public class LoginController : Controller
    {
        // public IActionResult Index()
        // {
        //     return View();
        // }

        // public IActionResult About()
        // {
        //     ViewData["Message"] = "Your application description page.";

        //     return View();
        // }

        // public IActionResult Contact()
        // {
        //     ViewData["Message"] = "Your contact page.";

        //     return View();
        // }

        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
//``````````````````````````````````````````````````````````````````````````````````````````````

        public ViewResult Index() {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MainPage");
        }


        [HttpGet]
        public ViewResult LoginForm() {
            return View();
        }

        [HttpPost]
        public ViewResult LoginForm(LoginViewModel loginViewModel) {
            if (ModelState.IsValid) 
            {
                Repository.AddResponse(loginViewModel);
                return View("PostLogin", loginViewModel);
            } 
            else 
            {
                // there is a validation error
                return View();
            }
        }

        // public ViewResult ListAccounts() {
        //     return View(Repository.Responses.Where(r => r.StayLoggedIn == true));
        // }

                public ViewResult ListAccounts() {
            return View(Repository.Responses);
        }


    }
}
