using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class User
    {

        private string _userName;
        private string _password;
        public string UserName
        {
            get { return _userName; }
            set
            {
                if (value.Length >= 6)
                {
                    _userName = value;
                }
                else Console.WriteLine("Yanlis daxil edilib");

            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                bool isupper = false;
                bool isdigit = false;
                foreach (var item in value)
                {
                    if (char.IsUpper(item))
                    {
                        isupper = true;
                    }
                    else if (char.IsDigit(item))
                    {
                        isdigit = true;
                    }

                }
                if (isupper && isdigit)
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Password sehv daxil edilib");
                }
            }


        }
        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;

        }

        public static bool PasswordChek(string password)
        {
            bool isupper = false;
            bool isdigit = false;
            foreach (var item in password)
            {
                if (char.IsUpper(item))
                {
                    isupper = true;
                }
                else if (char.IsDigit(item))
                {
                    isdigit = true;
                }

            }
            if (isupper && isdigit)
            {
                return true;
            }
            return false;


        }
        public virtual void Info()
        {
            Console.WriteLine($"UserName:{UserName} Password:{Password}");
        }

    }
}
