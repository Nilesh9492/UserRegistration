using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace USerRegistration
{
    class RegEx
    {
        public static string s = "^[A-Z][a-z]{2,}$";
        public void FirstName()
        {
            Regex exp = new Regex(s);
            Console.WriteLine("Enter First name :");
            string firstName = Console.ReadLine();
            bool result = Regex.IsMatch(firstName, s);
            if (result)
            {
                Console.WriteLine("Valid Name!");
            }
            else
            {
                Console.WriteLine("Invalid name!");
                Console.WriteLine("First name should start with Cap and minimum 3 characters");
            }
        }
        public void LastName()
        {
            Regex exp = new Regex(s);
            Console.WriteLine("Enter Last name :");
            string lastName = Console.ReadLine();
            bool result = Regex.IsMatch(lastName, s);
            if (result)
            {
                Console.WriteLine("Valid name");
            }
            else
            {
                Console.WriteLine("Invalid name");
                Console.WriteLine("Last name should start with Cap and minimum 3 characters");
            }
        }
        public void Email()
        {
            Console.WriteLine("Enter EMail :");
            string email = Console.ReadLine();
            string s = @"^[a-zA-Z]{3}([\- \+ _\.]*[a-zA-Z0-9]+)*@[a-zA-Z0-9]+\.[a-z]{2,3}(\.[a-zA-Z]{2,4}){0,1}$";
            Regex exp = new Regex(s);
            bool result = Regex.IsMatch(email, s);
            if (result)
            {
                Console.WriteLine("Valid EMail");
            }
            else
            {
                Console.WriteLine("Invalid EMail");
            }
        }
        public void Mobile()
        {
            Console.WriteLine("Enter Mobile : ");
            string number = Console.ReadLine();
            string s = @"^[1-9]{2}[ ][0-9]{10}$";
            Regex exp = new Regex(s);
            bool result = Regex.IsMatch(number, s);
            if (result)
            {
                Console.WriteLine("Valid Number");
            }
            else
            {
                Console.WriteLine("Invalid Number ");
            }
        }
        public void Password()
        {
            string s = @"^[a-zA-Z0-9]{8,}$";
            Regex regex = new Regex(s);
            Console.WriteLine("Enter password :");
            string password = Console.ReadLine();
            bool res = Regex.IsMatch(password, s);
            if (res)
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }
    }
}


