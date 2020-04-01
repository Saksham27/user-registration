using System;
using System.Text.RegularExpressions;

namespace userRegistration
{
    class UserRegistration : Validator
    {
        public string validateName(string firstName)
        {
            var expr = @"^[A-Z]{1}[a-z]{2,}$";
            var match = Regex.Match(firstName, expr, RegexOptions.None);
            if (match.Success)
                return "valid";
            else
                return "invalid";
        }

        static void Main(string[] args)
        {
            UserRegistration userRes = new UserRegistration();

            string[] name = UserInput.inputName(); // taking name from user
            string firstName = name[0]; // first name
            Console.WriteLine($"First name {userRes.validateName(firstName)}"); // validating first name
            string lastName = name[1]; // last name
            Console.WriteLine($"Last name {userRes.validateName(lastName)}"); // validating last name
        }
    }
}
