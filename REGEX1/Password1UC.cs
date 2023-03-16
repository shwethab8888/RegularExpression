using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX1
{
    public class Password1UC
    {
        public static bool IsValid(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[A-Z]).{8,}$");

        }
        public static void Password1_UC()
        {
            string password;

            while (true)
            {
                Console.Write("Enter your password: ");
                password = Console.ReadLine();

                if (Password1UC.IsValid(password))
                {
                    break;
                }

                Console.WriteLine("Invalid password. Please try again.");
            }

            Console.WriteLine($"Welcome, your password is valid: {password}");
        }
    }
}
