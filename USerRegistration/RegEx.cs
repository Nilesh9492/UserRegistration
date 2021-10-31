using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace USerRegistration
{
    class RegEx
    {

        public void FirstName()
        {
            string pattern = "^[A-Z][a-zA-Z]{2,}";
            string[] inputs = { "Nilesh", "Mahesh", "Devesh", "Vishesh", "Suresh", "Dinesh" };
            Regex regex = new Regex(pattern);
            Validating(inputs, regex);
        }
        public void LastName()
        {
            string pattern = "^[A-Z][a-zA-Z]{2,}";
            string[] inputs = { "Bhamare", "Patil", "Mahajan", "Thakur", "B", "Ma" };
            Regex regex = new Regex(pattern);
            Validating(inputs, regex);
        }
        public void Email()
        {
            string pattern = @"^[a-zA-z]{3}([\+ \- _ \.]*[a-zA-Z0-9]+)*[@][a-zA-z0-9]+(\.[a-z]{2,3})*$";
            string[] inputs = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" ,"abc","abc@.com","abc123@gmail.a", "abc123@.com" ,
            "abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a"};

            Regex regex = new Regex(pattern);
            Validating(inputs, regex);
        }
        public void MobileNumber()
        {
            string pattern = "^([9][1])+[ ]+[789]{1}[0-9]{9}$";
            string[] inputs = { "919653214561", "91 8794563211", "9632587410", "74123698520", "91 9629", "19 9234567811", "91 7302456786", "91 8220523456" };
            Regex regex = new Regex(pattern);
            Validating(inputs, regex);
        }
        public void Password()
        {
            string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&-+=()]).{8,}$";
            string[] inputs = { "Nil@fhh5645", "nilAAc44", "64564#@#$hjdvghAS","hjgjh.dgeg5454" };
            Regex regex = new Regex(pattern);
            Validating(inputs, regex);
        }
        public static void Validating(string[] arr, Regex regex)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool result = regex.IsMatch(arr[i]);
                if (result == true)
                {
                    Console.WriteLine(arr[i] +  "Valid");
                }
                else
                {
                    Console.WriteLine(arr[i] + "Invalid");
                }
            }
        }

    }
}


