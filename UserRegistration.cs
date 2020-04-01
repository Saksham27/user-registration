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

        public string validateEmail(string email)
        {
            var expr = @"^abc((\.[A-Z]+[a-z]*[0-9]*)|(\.[A-Z]*[a-z]+[0-9]*)|(\.[A-Z]*[a-z]*[0-9]+)?)?@bl\.co(\.[a-z]{2,})?$";
            var match = Regex.Match(email, expr, RegexOptions.None);
            if (match.Success)
                return "valid";
            else
                return "invalid";
        }

        public string validateNumber(string number)
        {
            var expr = @"^([0-9]{2}[ ]{1}[0-9]{10})$";
            var match = Regex.Match(number, expr, RegexOptions.None);
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

            string email = UserInput.inputEmail(); // taking email form user
            Console.WriteLine($"Email {userRes.validateEmail(email)}"); // validating email

            string number = UserInput.inputNumber(); // taking number from user
            Console.WriteLine($"Number {userRes.validateNumber(number)}"); // validating number


        }
    }
}
