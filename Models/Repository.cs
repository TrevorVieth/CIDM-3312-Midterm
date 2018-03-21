using System.Collections.Generic;

namespace MidtermVieth.Models {
    public static class Repository {
        private static List<LoginViewModel> responses = new List<LoginViewModel>();

        public static IEnumerable<LoginViewModel> Responses {
            get {
                return responses;
            }
        }


        public static void AddResponse(LoginViewModel response) {
            responses.Add(response);
        }

        // public static void AddRegResponse(RegistrationViewModel regResponse) {
        //     responses.Add(regResponse);
        // }
    }
}
