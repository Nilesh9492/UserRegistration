﻿using System;
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
    }
}