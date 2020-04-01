using System;
using System.Text.RegularExpressions;

namespace userRegistration
{
    class UserRegistration : Validator
    {
        public void ValidateFirstName(string firstName)
        {
            var expr = @"^[A-Z]{1}[a-z]{2,}$";
            var match = Regex.Match(firstName, expr, RegexOptions.None);
            if (match.Success)
                Console.WriteLine("Valid First Name");
            else
                Console.WriteLine("Invalid First Name");
            
        }

        static void Main(string[] args)
        {
            UserRegistration userRes = new UserRegistration();

            string firstName = UserInput.inputName(); // taking first name from user
            userRes.ValidateFirstName(firstName); // validating first name
        }
    }
}
