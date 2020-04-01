using System;
using System.Text.RegularExpressions;

namespace userRegistration
{
    class UserRegistration : Validator
    {

        public string checkMatch(string exp, string stringToMatch)
        {
            var match = Regex.Match(stringToMatch, exp, RegexOptions.None);
            if (match.Success)
                return "valid";
            else
                return "invalid";
        }

        public string validateName(string name)
        {
            var expr = @"^[A-Z]{1}[a-z]{2,}$";
            return this.checkMatch(expr, name);
            
        }

        public string validateEmail(string email)
        {
            var expr = @"^abc((\.[A-Z]+[a-z]*[0-9]*)|(\.[A-Z]*[a-z]+[0-9]*)|(\.[A-Z]*[a-z]*[0-9]+)?)?@bl\.co(\.[a-z]{2,})?$";
            return this.checkMatch(expr, email);
        }

        public string validateNumber(string number)
        {
            var expr = @"^([0-9]{2}[ ]{1}[0-9]{10})$";
            return this.checkMatch(expr, number);
        }

        public string validatePassword(string password)
        {
            var expr = @"^(?=.*[A-Z])(?=.*[0-9])(?=[^@#$%^&+=]*[@#$%^&+=][^@#$%^&+=]*$)(.{8,})$";
            return this.checkMatch(expr, password);
        }

        static void Main(string[] args)
        {
            UserRegistration userRes = new UserRegistration();

            string firstName = UserInput.inputFirstName(); // first name
            Console.WriteLine($"First name {userRes.validateName(firstName)}"); // validating first name
            string lastName = UserInput.inputLastName(); // last name
            Console.WriteLine($"Last name {userRes.validateName(lastName)}"); // validating last name

            string email = UserInput.inputEmail(); // taking email form user
            Console.WriteLine($"Email {userRes.validateEmail(email)}"); // validating email

            string number = UserInput.inputNumber(); // taking number from user
            Console.WriteLine($"Number {userRes.validateNumber(number)}"); // validating number

            string password = UserInput.inputPassword();
            Console.WriteLine($"Password {userRes.validatePassword(password)}"); // validating password



        }
    }
}
