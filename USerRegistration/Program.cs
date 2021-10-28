using System;

namespace USerRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Problem ");
            RegEx regEx = new RegEx();
            regEx.FirstName();
            regEx.LastName();
            regEx.Email();
            regEx.Mobile();
            regEx.Password();
        }
    }
}
