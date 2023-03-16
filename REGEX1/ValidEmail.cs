using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX1
{
    public class ValidEmail
    {
        public static bool IsValid(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)*@[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)*(?:\.[a-zA-Z]{2,})$");
        }

        public static void Valid_Email()
        {
            string email;

            while (true)
            {
                Console.Write("Enter your email: ");
                email = Console.ReadLine();

                if (ValidEmail.IsValid(email))
                {
                    break;
                }

                Console.WriteLine("Invalid email. Please try again.");
            }

            Console.WriteLine($"Email:- {email}");
        }
    }
}
