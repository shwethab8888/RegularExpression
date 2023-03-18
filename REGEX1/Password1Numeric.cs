using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX1
{
    public class Password1Numeric
    {

        public static bool IsValid(string password)
        {
            return Regex.IsMatch(password, "^[A-Z][0-9][a-zA-Z0-9]{6,}$";

        }
        public static void Password1_Numeric()
        {
            string password;

            while (true)
            {
                Console.Write("Enter your password: ");
                password = Console.ReadLine();

                if (Password1Numeric.IsValid(password))
                {
                    break;
                }

                Console.WriteLine("Invalid password. Please try again.");
            }

            Console.WriteLine($"Welcome, your password is valid: {password}");
        }
    }
}
