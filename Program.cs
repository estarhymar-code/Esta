using System;

namespace LoginAndLogout
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool loginAccess = false;

            string username = "admin";
            string password = "user";
            string usernameInput, passwordInput;

            while (loginAccess == false)
            {
                Console.Write("Enter username: ");
                usernameInput = Console.ReadLine();
                Console.Write("Enter password: ");
                passwordInput = Console.ReadLine();

                if (usernameInput == username && passwordInput == password)
                {
                    loginAccess = true;
                    Console.WriteLine("Access Granted!");
                }
                else
                {
                    Console.WriteLine("Wrong Credentials, Please Re-enter");
                }
            }
        }
    }
}
