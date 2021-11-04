using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace USerRegistration
{
    class RegEx
    {

        public string FirstName(string name)
        {
            string pattern = "^[A-Z][a-zA-Z]{2,}";
            Regex regex = new Regex(pattern);

            try
            {
                if (name == null)
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_EXCEPTION, "Name should not be null");
                }
                if (name == "")
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_EXCEPTION, "Name should not be empty");
                }
                if (regex.IsMatch(name))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (NullReferenceException e)
            {
                return (e.Message);
            }
        }
        public void LastName(string lname)
        {
            string pattern = "^[A-Z][a-zA-Z]{2,}";
            Regex regex = new Regex(pattern);

        }
        public string Email(string mail)
        {
            string pattern = @"^[a-zA-z]{3}([\+ \- _ \.]*[a-zA-Z0-9]+)*[@][a-zA-z0-9]+(\.[a-z]{2,3})*$";

            Regex regex = new Regex(pattern);
            try
            {
                if (regex.IsMatch(mail))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception)
            {
                return "Email should not be null";
            }


        }
        public string MobileNumber(string number)
        {
            string pattern = "^([9][1])+[ ]+[789]{1}[0-9]{9}$";
            Regex regex = new Regex(pattern);
            try
            {
                if (number == null)
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_EXCEPTION, "Number should not be null");
                }
                if (number == "")
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_EXCEPTION, "Number should not be empty");
                }
                if (regex.IsMatch(number))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception e)
            {
                return (e.Message);
            }
        }
        public string Password(string password)
        {
            string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&-+=()]).{8,}$";
            Regex regex = new Regex(pattern);
            try
            {
                if (password == null)
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_EXCEPTION, "Password should not be null");
                }
                if (password == "")
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_EXCEPTION, "Password should not be empty");
                }
                if (regex.IsMatch(password))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception e)
            {
                return (e.Message);
            }

        }
        public static string TestUserRegistration(UserAnnotation userRegistration)
        {
            ValidationContext validationContext = new ValidationContext(userRegistration, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(userRegistration, validationContext, validationResults, true);
            try
            {
                if (!valid)
                {
                    foreach (ValidationResult i in validationResults)
                    {
                        return "Sad";
                    }
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

    }
}


