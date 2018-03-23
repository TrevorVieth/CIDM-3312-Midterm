using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MidtermVieth.Models;

namespace MidtermVieth.Controllers
{
    public class AccountCreationController : Controller
    {

        public ViewResult Index() {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MainPage");
        }


        [HttpGet]
        public ViewResult AccountCreationForm() {
            return View();
        }

        [HttpPost]
        public ViewResult AccountCreationForm(AccountCreationViewModel accountCreationModel) {
            if (ModelState.IsValid) 
            {
                Repository.AddResponse(accountCreationModel);
                return View("PostAccountCreation", accountCreationModel);
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
