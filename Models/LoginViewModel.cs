using System.ComponentModel.DataAnnotations;

namespace MidtermVieth.Models {

    public class LoginViewModel {

        // [Required(ErrorMessage = "Please enter your email address")]
        // [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        // public string Email { get; set; }




       

        // [bool IsValidEmail(string email)
        // {
        //     try {
        //         var addr = new System.Net.Mail.MailAddress(email);
        //         return true;
        //     }
        //     catch {
        //         return false;
        //     }
        // }, ErrorMessage = "Please enter a valid email address")]


        // private string email;
        // public string Email 
        // { 
        //     get
        //     { 
        //         return email;
        //     }
        //     set
        //     {
        //         try 
        //         {
        //             var addr = new System.Net.Mail.MailAddress(Email);
        //             email = value;
        //         }
        //         catch 
        //         {
                    
        //         }
        //     }
        // }


        // private string email;
        // public string Email 
        // { 
        //     get
        //     { 
        //         return email;
        //     }
        //     set
        //     {
        //         if(email.IndexOf('@') > 1 
        //         && email.IndexOf('.') > 4 
        //         && email.IndexOf('@') < email.IndexOf('.')) 
        //         {
        //            email = Email;
        //         }
        //         else 
        //         {
        //         }
        //     }
        // }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please specify whether you want to stay logged in or not.")]
        public bool? StayLoggedIn { get; set; }
    }
}
