using System.ComponentModel.DataAnnotations;

namespace MidtermVieth.Models {

    public class LoginViewModel {

//failed attempts to validate without regex
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

//----------------------------------------------------------
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
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$",
        ErrorMessage = "Please enter a valid password that is at least eight characters in length, contains at least one upper case letter, one lower case letter, one digit, and one special character.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please specify whether you want to stay logged in or not.")]
        public bool? StayLoggedIn { get; set; }
    }
}
