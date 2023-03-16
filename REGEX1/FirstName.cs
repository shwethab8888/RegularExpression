using REGEX1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX1
{
    public class FirstName
    {
        public static bool IsValid(string firstName)
        {
            return Regex.IsMatch(firstName, @"^[A-Z][a-z]{2,}$");
        }

        public static void First_Name()
        {

            string firstName;

            while (true)
            {
                Console.Write("Enter your first name: ");
                firstName = Console.ReadLine();

                if (FirstName.IsValid(firstName))
                {
                    break;
                }

                Console.WriteLine("Invalid first name. Please try again.");
            }

            Console.WriteLine($"Welcome, {firstName}!");
        }

    }

}
