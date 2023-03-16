using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX1
{
    public class PhoneNumber
    {
        public static bool IsValid(string phonenumber)
        {
            return Regex.IsMatch(phonenumber, @"^[1-9]{2}[: :][0-9]{10}$");
        }
        public static void Phone_Number()
        {
            string phoneNumber;

            while (true)
            {
                Console.Write("Enter your phone number: ");
                phoneNumber = Console.ReadLine();

                if (PhoneNumber.IsValid(phoneNumber))
                {
                    break;
                }

                Console.WriteLine("Invalid phone number. Please try again.");
            }

            Console.WriteLine($"MobileNumber:- {phoneNumber}");
        }
    }
}
