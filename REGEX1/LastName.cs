using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX1
{
    public class LastName
    {

        public static bool IsValid(string lastName)
        {
            return Regex.IsMatch(lastName, "^[A-Z][a-zA-Z]{2,}$");
        }

        public static void Last_Name()
        {
            string lastName;

            while (true)
            {
                Console.Write("Enter your last name: ");
                lastName = Console.ReadLine();

                if (LastName.IsValid(lastName))
                {
                    break;
                }

                Console.WriteLine("Invalid last name. Please try again.");
            }

            Console.WriteLine($"Welcome, {lastName}!");
        }
    }
}
