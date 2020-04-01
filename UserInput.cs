using System;
using System.Collections.Generic;
using System.Text;

namespace userRegistration
{
    class UserInput
    {
        public static string[] inputName() // method to take name from user
        {
            string[] name = new string[2];
            Console.Write("Enter Name : ");
            var nameString = Console.ReadLine();
            name = nameString.Split(" ");
            return name;
        }
        
        public static string inputEmail() // method to take email from user
        {
            Console.Write("Enter email : ");
            return Console.ReadLine(); 
        }

        public static string inputNumber() // method to take number from user
        {
            Console.Write("Enter number with country code : ");
            return Console.ReadLine();
        }
    }
}
