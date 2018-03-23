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

        public ViewResult Index() {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MainPage");
        }


        [HttpGet]
        public ViewResult LoginForm() {
            return View("LoginForm");
        }

        [HttpPost]
        public ViewResult LoginForm(LoginViewModel loginViewModel) {
            if (ModelState.IsValid) 
            {
                return View("PostLogin");

//Tried to search repository for user but couldnt get contains to work.
                
                // if (Repository.Responses.Any (str => str.Contains(loginViewModel.Email)))
                // { 
                //     if (Repository.Responses.Any (str => str.Contains(loginViewModel.Email)))
                //     {
                //         return View("PostLogin", loginViewModel);
                //     }
                //     else
                //     {
                //         return View("FailedLogin");
                //     }
                // }
                // else
                // {
                //     return View("FailedLogin");
                // }
                //---------------------------------------------------------------------------


                //public string EEmail = LoginViewModel.Email;
                //if(Repository.Responses.Where(r => r.Contains(EEmail) == true))

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
