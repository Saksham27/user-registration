using System;
using System.Collections.Generic;
using System.Text;

namespace userRegistration
{
    class UserInput
    {
        /// <summary>
        /// method to take first name from user
        /// </summary>
        /// <returns></returns>
        public static string inputFirstName() 
        {
            Console.Write("Enter First name : ");
            return Console.ReadLine();
        }

        /// <summary>
        /// method to take last name from user
        /// </summary>
        /// <returns></returns>
        public static string inputLastName()
        {
            Console.Write("Enter Last name : ");
            return Console.ReadLine();
        }

        /// <summary>
        /// method to take email from user
        /// </summary>
        /// <returns></returns>
        public static string inputEmail()
        {
            Console.Write("Enter email : ");
            return Console.ReadLine(); 
        }

        /// <summary>
        /// method to take number from user
        /// </summary>
        /// <returns></returns>
        public static string inputNumber()
        {
            Console.Write("Enter number with country code : ");
            return Console.ReadLine();
        }

        /// <summary>
        /// method to take password from user
        /// </summary>
        /// <returns></returns>
        public static string inputPassword()
        {
            Console.Write("Enter password : ");
            return Console.ReadLine();
        }
    }
}
