using System;
using System.Text.RegularExpressions;

namespace userRegistration
{
    class UserRegistration : IValidator 
    {
        /// <summary>
        /// interface method to match inputted string with inputted regular expression
        /// </summary>
        /// <param name="regexExpression"> regular expression </param>
        /// <param name="stringToMatch"> string to match with regular expression </param>
        /// <returns></returns>
        public string checkMatch(string regexExpression, string stringToMatch)
        {
            Match match = Regex.Match(stringToMatch, regexExpression, RegexOptions.None);
            if (match.Success)
                return "valid";
            else
                return "invalid";
        }

        /// <summary>
        /// interface method to validate name
        /// </summary>
        /// <param name="name"> the name string to be checked for validation </param>
        /// <returns></returns>
        public string validateName(string name)
        {
            string expression = @"^[A-Z]{1}[a-z]{2,}$";
            return this.checkMatch(expression, name);
            
        }

        /// <summary>
        /// interface method to validate email
        /// </summary>
        /// <param name="email"> the email string to be checked for validation </param>
        /// <returns></returns>
        public string validateEmail(string email)
        {
            string expression = @"^abc((\.[A-Z]+[a-z]*[0-9]*)|(\.[A-Z]*[a-z]+[0-9]*)|(\.[A-Z]*[a-z]*[0-9]+)?)?@bl\.co(\.[a-z]{2,})?$";
            return this.checkMatch(expression, email);
        }

        /// <summary>
        /// interface method to validate number
        /// </summary>
        /// <param name="number"> the number to be checked for validation </param>
        /// <returns></returns>
        public string validateNumber(string number)
        {
            string expression = @"^([0-9]{2}[ ]{1}[0-9]{10})$";
            return this.checkMatch(expression, number);
        }

        /// <summary>
        /// interface method to validate password
        /// </summary>
        /// <param name="password"> the password to be checked for validation </param>
        /// <returns></returns>
        public string validatePassword(string password)
        {
            string expression = @"^(?=.*[A-Z])(?=.*[0-9])(?=[^@#$%^&+=]*[@#$%^&+=][^@#$%^&+=]*$)(.{8,})$";
            return this.checkMatch(expression, password);
        }

        static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();

            string firstName = UserInput.inputFirstName();      // first name
            Console.WriteLine($"First name {userRegistration.validateName(firstName)}");     // validating first name
            string lastName = UserInput.inputLastName();        // last name
            Console.WriteLine($"Last name {userRegistration.validateName(lastName)}");       // validating last name

            string email = UserInput.inputEmail();      // taking email form user
            Console.WriteLine($"Email {userRegistration.validateEmail(email)}");     // validating email

            string number = UserInput.inputNumber();        // taking number from user
            Console.WriteLine($"Number {userRegistration.validateNumber(number)}");      // validating number

            string password = UserInput.inputPassword();        // taking password from user
            Console.WriteLine($"Password {userRegistration.validatePassword(password)}");    // validating password



        }
    }
}
