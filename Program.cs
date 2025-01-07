using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Uniform_Ordering_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Log in first!");

            Console.Write("Username: ");
            string userName = Console.ReadLine();

            Console.Write("Password: ");
            string userPassword = Console.ReadLine();

            if (userName == "user" && userPassword == "password")
            {
                Console.WriteLine("Log in Successfully!");
            } else { Console.WriteLine("Invalid! Enter the pre defined user and password"); return; }


            Console.WriteLine("Welcome to School Uniform Ordering System! ");

            Console.WriteLine("SUNN School Uniforms \n 1.) CAS\n 2.) CICTE \n 3.) CFAS\n");
            Console.Write("Choose a number according to your program department: ");
            string chooseDepartment = Console.ReadLine();


            if (chooseDepartment == "1")
            {
                Console.WriteLine("CAS Department");
                Console.WriteLine("1.) Sport Uniform");
                Console.WriteLine("2.) SUNN Uniform");
                Console.WriteLine("3.) Department Jersey\n");


                Console.Write("Choose a number if you want to buy it type (no) if not and type (all) if you want to buy them all: ");
                string pickItem = Console.ReadLine();

                if (pickItem == "1")
                {
                    Console.WriteLine("CAS Department: ");
                    Console.WriteLine("1.) Sport Uniform \n Price: 5,000");

                    Console.Write("Would you like to buy it? (yes/no): ");
                    string decide = Console.ReadLine();

                    if (decide == "yes")
                    {
                        Console.WriteLine("Please Enter Your name and address: ");
                        Console.Write("Address: ");
                        string userAddress = Console.ReadLine();

                        Console.Write("First Name: ");
                        string nameUser = Console.ReadLine();

                        Console.WriteLine($"Thank you for purchasing to our uniform {nameUser}\n And your order will be deliver according to your address: {userAddress}");
                        Console.WriteLine("Please Prepare 5,00 pesos for upcoming delivery on Dec. 25, 2025");

                    }
                    else if (decide == "no")
                    {
                        Console.WriteLine("OK!");
                    } else { Console.WriteLine("Invalid! (yes/no) only."); }
                }

                else if (pickItem == "2")
                {
                    Console.WriteLine("CAS Department: ");
                    Console.WriteLine("2.) SUNN Uniform \n Price: 5,000");

                    Console.Write("Would you like to buy it? (yes/no): ");
                    string decide = Console.ReadLine();

                    if (decide == "yes")
                    {
                        Console.WriteLine("Please Enter Your name and address: ");
                        Console.Write("Address: ");
                        string userAddress = Console.ReadLine();

                        Console.Write("First Name: ");
                        string nameUser = Console.ReadLine();

                        Console.WriteLine($"Thank you for purchasing to our uniform {nameUser}\n And your order will be deliver according to your address: {userAddress}");
                        Console.WriteLine("Please Prepare 5,00 pesos for upcoming delivery on Dec. 25, 2025");

                    }
                    else if (decide == "no")
                    {
                        Console.WriteLine("OK!");
                    } else { Console.WriteLine("Invalid! (yes/no) only."); }
                }
                else if (pickItem == "3")
                {
                    Console.WriteLine("CAS Department: ");
                    Console.WriteLine("3.) Department Jersey \n Price: 5,000");

                    Console.Write("Would you like to buy it? (yes/no): ");
                    string decide = Console.ReadLine();

                    if (decide == "yes")
                    {
                        Console.WriteLine("Please Enter Your name and address: ");
                        Console.Write("Address: ");
                        string userAddress = Console.ReadLine();

                        Console.Write("First Name: ");
                        string nameUser = Console.ReadLine();

                        Console.WriteLine($"Thank you for purchasing to our uniform {nameUser}\n And your order will be deliver according to your address: {userAddress}");
                        Console.WriteLine("Please Prepare 5,00 pesos for upcoming delivery on Dec. 25, 2025");

                    }
                    else if (decide == "no")
                    {
                        Console.WriteLine("OK!");
                    } else { Console.WriteLine("Invalid! (yes/no) only."); }
                }
                else if (pickItem == "all")
                {
                    Console.WriteLine("CAS Department");
                    Console.WriteLine("1.) Sport Uniform Price: 5,000");
                    Console.WriteLine("2.) SUNN Uniform Price: 5,000");
                    Console.WriteLine("3.) Department Jersey Price: 5,000\n");

                    Console.Write("Would you like to buy them all? (yes/no): ");
                    string decide = Console.ReadLine();

                    if (decide == "yes")
                    {
                        Console.WriteLine("Please Enter Your name and address: ");
                        Console.Write("Address: ");
                        string userAddress = Console.ReadLine();

                        Console.Write("First Name: ");
                        string nameUser = Console.ReadLine();

                        Console.WriteLine($"Thank you for purchasing to our uniform {nameUser}\n And your order will be deliver according to your address: {userAddress}");
                        Console.WriteLine($"Please Prepare {5000 * 3} pesos for upcoming delivery on Dec. 25, 2025");

                    }
                    else if (decide == "no")
                    {
                        Console.WriteLine("OK!");
                    }
                    else { Console.WriteLine("Invalid! (yes/no) only."); }

                }
                else if (pickItem == "no") 
                {
                    Console.WriteLine("OK! bye");
                }

                else { Console.WriteLine("Invalid! Please Enter The correct number according to the list and (no) if not"); }
            }



            else if (chooseDepartment == "2")
            {
                Console.WriteLine("CICTE Department");
                Console.WriteLine("1.) Sport Uniform");
                Console.WriteLine("2.) SUNN Uniform");
                Console.WriteLine("3.) Department Jersey");



                Console.Write("Choose a number if you want to buy it type (no) if not and type (all) if you want to buy them all: ");
                string pickItem = Console.ReadLine();


                if (pickItem == "1")
                {
                    Console.WriteLine("CICTE Department: ");
                    Console.WriteLine("1.) Sport Uniform \n Price: 5,000");

                    Console.Write("Would you like to buy it? (yes/no): ");
                    string decide = Console.ReadLine();

                    if (decide == "yes")
                    {
                        Console.WriteLine("Please Enter Your name and address: ");
                        Console.Write("Address: ");
                        string userAddress = Console.ReadLine();

                        Console.Write("First Name: ");
                        string nameUser = Console.ReadLine();

                        Console.WriteLine($"Thank you for purchasing to our uniform {nameUser}\n And your order will be deliver according to your address: {userAddress}");
                        Console.WriteLine("Please Prepare 5,00 pesos for upcoming delivery on Dec. 25, 2025");

                    }
                    else if (decide == "no")
                    {
                        Console.WriteLine("OK! kupal kaba?");
                    }
                    else { Console.WriteLine("Invalid! (yes/no) only."); }
                }

                else if (pickItem == "2")
                {
                    Console.WriteLine("CICTE Department: ");
                    Console.WriteLine("2.) SUNN Uniform \n Price: 5,000");

                    Console.Write("Would you like to buy it? (yes/no): ");
                    string decide = Console.ReadLine();

                    if (decide == "yes")
                    {
                        Console.WriteLine("Please Enter Your name and address: ");
                        Console.Write("Address: ");
                        string userAddress = Console.ReadLine();

                        Console.Write("First Name: ");
                        string nameUser = Console.ReadLine();

                        Console.WriteLine($"Thank you for purchasing to our uniform {nameUser}\n And your order will be deliver according to your address: {userAddress}");
                        Console.WriteLine("Please Prepare 5,00 pesos for upcoming delivery on Dec. 25, 2025");

                    }
                    else if (decide == "no")
                    {
                        Console.WriteLine("OK!");
                    }
                    else { Console.WriteLine("Invalid! (yes/no) only."); }
                }
                else if (pickItem == "3")
                {
                    Console.WriteLine("CICTE Department: ");
                    Console.WriteLine("3.) Department Jersey \n Price: 5,000");

                    Console.Write("Would you like to buy it? (yes/no): ");
                    string decide = Console.ReadLine();

                    if (decide == "yes")
                    {
                        Console.WriteLine("Please Enter Your name and address: ");
                        Console.Write("Address: ");
                        string userAddress = Console.ReadLine();

                        Console.Write("First Name: ");
                        string nameUser = Console.ReadLine();

                        Console.WriteLine($"Thank you for purchasing to our uniform {nameUser}\n And your order will be deliver according to your address: {userAddress}");
                        Console.WriteLine("Please Prepare 5,00 pesos for upcoming delivery on Dec. 25, 2025");

                    }
                    else if (decide == "no")
                    {
                        Console.WriteLine("OK!");
                    }
                    else { Console.WriteLine("Invalid! (yes/no) only."); }
                }
                else if (pickItem == "all")
                {
                    Console.WriteLine("CAS Department");
                    Console.WriteLine("1.) Sport Uniform Price: 5,000");
                    Console.WriteLine("2.) SUNN Uniform Price: 5,000");
                    Console.WriteLine("3.) Department Jersey Price: 5,000\n");

                    Console.Write("Would you like to buy them all? (yes/no): ");
                    string decide = Console.ReadLine();

                    if (decide == "yes")
                    {
                        Console.WriteLine("Please Enter Your name and address: ");
                        Console.Write("Address: ");
                        string userAddress = Console.ReadLine();

                        Console.Write("First Name: ");
                        string nameUser = Console.ReadLine();

                        Console.WriteLine($"Thank you for purchasing to our uniform {nameUser}\n And your order will be deliver according to your address: {userAddress}");
                        Console.WriteLine($"Please Prepare {5000 * 3} pesos for upcoming delivery on Dec. 25, 2025");

                    }
                    else if (decide == "no")
                    {
                        Console.WriteLine("OK!");
                    }
                    else { Console.WriteLine("Invalid! (yes/no) only."); }

                }
                else if (pickItem == "no")
                {
                    Console.WriteLine("OK! bye");
                }

                else { Console.WriteLine("Invalid! Please Enter The correct number according to the list and (no) if not"); }

            }
            else if (chooseDepartment == "3")
            {
                Console.WriteLine("CFAS Department");
                Console.WriteLine("1.) Sport Uniform");
                Console.WriteLine("2.) SUNN Uniform");
                Console.WriteLine("3.) Department Jersey");

                Console.Write("Choose a number if you want to buy it type (no) if not and type (all) if you want to buy them all: ");
                string pickItem = Console.ReadLine();


                if (pickItem == "1")
                {
                    Console.WriteLine("CFAS Department: ");
                    Console.WriteLine("1.) Sport Uniform \n Price: 5,000");

                    Console.Write("Would you like to buy it? (yes/no): ");
                    string decide = Console.ReadLine();

                    if (decide == "yes")
                    {
                        Console.WriteLine("Please Enter Your name and address: ");
                        Console.Write("Address: ");
                        string userAddress = Console.ReadLine();

                        Console.Write("First Name: ");
                        string nameUser = Console.ReadLine();

                        Console.WriteLine($"Thank you for purchasing to our uniform {nameUser}\n And your order will be deliver according to your address: {userAddress}");
                        Console.WriteLine("Please Prepare 5,00 pesos for upcoming delivery on Dec. 25, 2025");

                    }
                    else if (decide == "no")
                    {
                        Console.WriteLine("OK!");
                    }
                    else { Console.WriteLine("Invalid! (yes/no) only."); }
                }

                else if (pickItem == "2")
                {
                    Console.WriteLine("CFAS Department: ");
                    Console.WriteLine("2.) SUNN Uniform \n Price: 5,000");

                    Console.Write("Would you like to buy it? (yes/no): ");
                    string decide = Console.ReadLine();

                    if (decide == "yes")
                    {
                        Console.WriteLine("Please Enter Your name and address: ");
                        Console.Write("Address: ");
                        string userAddress = Console.ReadLine();

                        Console.Write("First Name: ");
                        string nameUser = Console.ReadLine();

                        Console.WriteLine($"Thank you for purchasing to our uniform {nameUser}\n And your order will be deliver according to your address: {userAddress}");
                        Console.WriteLine("Please Prepare 5,00 pesos for upcoming delivery on Dec. 25, 2025");

                    }
                    else if (decide == "no")
                    {
                        Console.WriteLine("OK!");
                    }
                    else { Console.WriteLine("Invalid! (yes/no) only."); }
                }
                else if (pickItem == "3")
                {
                    Console.WriteLine("CFAS Department: ");
                    Console.WriteLine("3.) Department Jersey \n Price: 5,000");

                    Console.Write("Would you like to buy it? (yes/no): ");
                    string decide = Console.ReadLine();

                    if (decide == "yes")
                    {
                        Console.WriteLine("Please Enter Your name and address: ");
                        Console.Write("Address: ");
                        string userAddress = Console.ReadLine();

                        Console.Write("First Name: ");
                        string nameUser = Console.ReadLine();

                        Console.WriteLine($"Thank you for purchasing to our uniform {nameUser}\n And your order will be deliver according to your address: {userAddress}");
                        Console.WriteLine("Please Prepare 5,00 pesos for upcoming delivery on Dec. 25, 2025");

                    }
                    else if (decide == "no")
                    {
                        Console.WriteLine("OK!");
                    }
                    else { Console.WriteLine("Invalid! (yes/no) only."); }
                }
                else if (pickItem == "no")
                    {
                        Console.WriteLine("OK!");
                    }
                else if (pickItem == "all")
                {
                    Console.WriteLine("CAS Department");
                    Console.WriteLine("1.) Sport Uniform Price: 5,000");
                    Console.WriteLine("2.) SUNN Uniform Price: 5,000");
                    Console.WriteLine("3.) Department Jersey Price: 5,000\n");

                    Console.Write("Would you like to buy them all? (yes/no): ");
                    string decide = Console.ReadLine();

                    if (decide == "yes")
                    {
                        Console.WriteLine("Please Enter Your name and address: ");
                        Console.Write("Address: ");
                        string userAddress = Console.ReadLine();

                        Console.Write("First Name: ");
                        string nameUser = Console.ReadLine();

                        Console.WriteLine($"Thank you for purchasing to our uniform {nameUser}\n And your order will be deliver according to your address: {userAddress}");
                        Console.WriteLine($"Please Prepare {5000 * 3} pesos for upcoming delivery on Dec. 25, 2025");

                    }
                    else if (decide == "no")
                    {
                        Console.WriteLine("OK!");
                    }
                    else { Console.WriteLine("Invalid! (yes/no) only."); }

                }
                else { Console.WriteLine("Invalid! Please Enter The correct number according to the list and (no) if not"); }


            } else { Console.WriteLine("Invalid! Please Enter a number according to the list"); }

           



            
        }
    }
}
