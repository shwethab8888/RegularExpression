using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX1
{
    public class Password8Char
    {
        public static bool IsValid(string password)
        {
            return Regex.IsMatch(password, @"^.{8,}$");

        }
        public static void Password8_Char()
        {
            string password;

            while (true)
            {
                Console.Write("Enter Password: ");
                password = Console.ReadLine();

                if (Password8Char.IsValid(password))
                {
                    break;
                }

                Console.WriteLine("Invalid password. Please try again.");
            }

            Console.WriteLine($"ValidPassword: {password}");
        }
    }
}
