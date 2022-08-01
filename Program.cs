using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            string UserName;
            string Password;

            do
            {
                Console.WriteLine("UserName daxil edin");
                UserName = Console.ReadLine();
                if (string.IsNullOrEmpty(UserName) || UserName.Length < 6)
                {
                    Console.WriteLine("Sehv daxil edilib");
                }

            } while (string.IsNullOrEmpty(UserName) || UserName.Length < 6);

            do
            {
                Console.WriteLine("Passord daxil edin");
                Password = Console.ReadLine();
                if (!User.PasswordChek(Password))
                {
                    Console.WriteLine("Sehv daxil edilib");
                }

            } while (!User.PasswordChek(Password));

            Admin admin = new Admin(UserName, Password, true, "sistem");
            admin.Info();
            #endregion
        }
    }
}
