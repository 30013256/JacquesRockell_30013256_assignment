using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//jacques rockell
namespace ConsoleApp35
{
    class Program
    {
        public static void Main()
        {
            //welcome message
            Console.WriteLine("................................................................");
            Console.WriteLine(".........................Welcome to the.........................");
            Console.WriteLine("................The Rotorua Thermal Holiday park................");
            Console.WriteLine("..........................Login system..........................");
            Console.WriteLine("................................................................");

            //asks for username
            Console.Write("\n\nEnter your username(minimum 8 characters): ");
            //gets the username input for username and saves it to username variable
            string username = Console.ReadLine().Trim();
            //calls metod to valadate username is at least 8 charaters long
            Console.WriteLine(validateUsername(username));
            //checks what the return from the validateUsername method
            if (validateUsername(username) == "Username rejected")
            {
                //gives them option to exit or retry 
                Console.WriteLine("Would you like to retry(Y/N)");
                string input = Console.ReadLine().ToLower().Trim();
                while (input == "y")
                {
                    Console.Clear();
                    Main();
                }
                while (input != "y")
                {
                    Console.WriteLine("Press Enter to Quit");
                    Console.ReadLine();
                    System.Environment.Exit(1);
                }
            }
            //if the the username wasnt rejected this runs
            else
            {
                //this keeps looping forever unless they exit 
                int w = 1;
                while(w == 1)
                {
                    Console.Clear();
                    Console.Write("Enter password(minimum 8 characters): ");
                    string password1 = Console.ReadLine().Trim();
                    Console.Write("Renter your password: ");
                    string password2 = Console.ReadLine().Trim();
                    Console.WriteLine(validatePassword(password1, password2));
                    //shows username and password set message if the validatePassword method returns Password accepted 
                    if (validatePassword(password1, password2) == "Passwords accepted")
                    {
                        Console.Clear();
                        Console.WriteLine("Username and Password have been set.\nPress Enter to Quit ");
                        Console.ReadLine();
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        //if password is rejected it gives option to retry or exit
                        Console.WriteLine("Would you like to retry(Y/N)");
                        string input = Console.ReadLine().ToLower().Trim();

                        if (input == "y")
                        {
                            
                        }
                        else if (input != "y")
                        {
                            Console.WriteLine("Press Enter to Quit");
                            Console.ReadLine();
                            System.Environment.Exit(1);
                        }
                    }
                }               
            }
        }

        //Metod to check the username length
        public static string validateUsername(string username)
        {
            if (username.Length <= 7)
            {
                return "Username rejected";
            }
            else
            {
                return "Username accepted";
            }
        }
        //method to check if passwords are long enough and if they match
        public static string validatePassword(string password1, string password2)
        {
            if (password1.Length <= 7)
            {
                return "Password must be atleast 8 characters";
            }
            else
            {
                if (password1 == password2)
                {
                    return "Passwords accepted";
                }
                else
                {
                    return "Passwords do not match";
                }
            }
        }
    }
}
