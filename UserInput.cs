using System;
using System.Collections.Generic;
using System.Text;

namespace userRegistration
{
    class UserInput
    {
        public static string[] inputName()
        {
            string[] name = new string[2];
            Console.Write("Enter Name : ");
            var nameString = Console.ReadLine();
            name = nameString.Split(" ");
            return name;

        }
    }
}
