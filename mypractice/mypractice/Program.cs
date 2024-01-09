using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mypractice
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var userData = new UserInfo();
            Console.WriteLine("-----------------------------------------");
            string bindedData;
            string data;
            
            
           Console.WriteLine();
           //loginPage();
            
          //  void loginPage()
            //{
                bool success = false;
                while (!success)
                {
               

                Console.WriteLine("Enter your Username:");
                    string _userName = Console.ReadLine();
                    // _userName = _userName.ToUpper();

                   
                    Console.WriteLine("Enter your Password:");
                    string _password = Console.ReadLine();

                    //userData.Username = _userName;
                    //userData.Password = _password;
                    string userDataUsername = userData.Username;
                    string userDataPassword = userData.Password;

                    if (userDataUsername == _userName && userDataPassword == _password)
                    {
                        mainPage();
                    }
                    else
                    {
                        Console.WriteLine("If you have no account! Create One:");
                        Console.WriteLine("Enter Y to create new account");
                        Console.WriteLine("if you forgot your password: enter Y");
                        string response = Console.ReadLine();
                        if (response == "Y")
                        {
                            bindedData = createAccountOrForgotPassword();
                            data = bindedData;
                            int num = data.IndexOf('&');
                            string username = data.Substring(0, num);
                            string password = data.Substring(num+1);
                            userData.Username = username;
                            userData.Password = password;

                        //     Console.WriteLine(userData.Password);

                        }
                    }

                }
          //  }
           
           


            Console.WriteLine("------------------------------------------");
            Console.ReadKey();
        }
        static string createAccountOrForgotPassword()
        {
            string dataBinding = null;
            Console.WriteLine("Do you wish to create account or you forgot your password");
            Console.WriteLine("Enter Y: for create new account/ N: for forgot password");
            string response = Console.ReadLine();
            response = response.ToUpper();
            if (response == "Y")
            {
                dataBinding = createAccount();
            }
            else if(response == "N")
            {
                forgotPassword();
            }
            else
            {
                Console.WriteLine("Incorrect response");
            }
            return dataBinding;
        }
        static string createAccount()
        {
            bool successUsername = false;
            bool successPassword = false;
            string password1 = null;
            string username1 = null;
            while (successUsername == false)
            {
                Console.WriteLine("Enter your new username:");
                 username1 = Console.ReadLine();
                Console.WriteLine("Confirm your Username");
                string username2 = Console.ReadLine();
                if (username1 != username2)
                {
                    Console.WriteLine($"Your Info doest match:{username1} is not the same as {username2} Enter the same info please");

                }
                else
                {
                    Console.WriteLine ("Account Created Sucessfully");
                    successUsername = true;
                }
            }
            while (!successPassword)
            {
                Console.WriteLine("Enter your new password:");
                 password1 = Console.ReadLine();
                Console.WriteLine("Confirm your password");
                string password2 = Console.ReadLine();
                if (password1 != password2)
                {
                    Console.WriteLine($"Your Info doest match:{password1} is not the same as {password2} Enter the same info please");

                }
                else
                {
                    Console.WriteLine("Account Created Sucessfully");
                    successPassword = true;
                }
            }

           // var userData = new UserInfo();
           // userData.Username = username1;
          //  userData.Password = password1;
         
            string stringBinding = $"{username1}&{password1}";
           
            return stringBinding;
        }
        static string forgotPassword()
        {
            bool success = false;
            string password1 = null;
            while (success == false)
            {
                Console.WriteLine("Enter your new password:");
                password1 = Console.ReadLine();
                Console.WriteLine("Confirm your Username");
                string password2 = Console.ReadLine();
                if (password1 != password2)
                {
                    Console.WriteLine($"Your Info doest match:{password1} is not the same as {password2} Enter the same info please");

                }
                else
                {
                    Console.WriteLine("Account Created Sucessfully");
                    success = true;
                }

            }
            return password1;
        }
        static void mainPage()
        {
            
            Console.WriteLine("Welcome to the mian page");
        }
    }

}
