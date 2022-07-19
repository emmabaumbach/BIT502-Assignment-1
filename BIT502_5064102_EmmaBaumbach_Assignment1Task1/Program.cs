using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT502_5064102_EmmaBaumbach_Assignment1Task1
{
    class Program
    {
        static void UnknownCommand(string sel)
        {
            Console.WriteLine("\n Unknown command: " + sel);
        }
        static void MembershipDetails()
        {
            Console.Write("\n Please select which membership you'd like to view: \n\n [1] Basic\n [2] Regular\n [3] Premium\n [4] Exit application\n ");
            string sel = (Console.ReadLine());
            float[] rates = { 10.00f, 15.00f, 20.00f };

            if (sel == "1") // basic membership
            {
                Console.WriteLine("\n Basic Membership\n\n Weekly $" + rates[0] + "\n Monthly $" + rates[0] * 4);
            }
            else if (sel == "2") // regular membership
            {
                Console.WriteLine("\n Regular Membership\n\n Weekly $" + rates[1] + "\n Monthly $" + rates[1] * 4);
            }
            else if (sel == "3") // premium membership
            {
                Console.WriteLine("\n Premium Membership\n\n Weekly $" + rates[2] + "\n Monthly $" + rates[2] * 4);
            }
            else if (sel == "4") // exit application
            {
                Environment.Exit(0);
            }
            else
            {
                UnknownCommand(sel);
            }
        }
        static void CalculateBMI()
        {
            Console.Write("\n Please enter your height in metres: (e.g. 1.6)\n ");
            float userHeight = Convert.ToSingle(Console.ReadLine());
            Console.Clear();
            Console.Write("\n Please enter your weight in kilograms: (e.g. 56)\n ");
            float userWeight = Convert.ToSingle(Console.ReadLine());
            Console.Clear();
            float userBMI = userWeight / (userHeight * userHeight);

            var BMI_output = "";

            if (userBMI < 18.5) //If BMI is less than 18.5
            {
                BMI_output = "Underweight";
            }
            if (userBMI >= 18.5 && userBMI < 25) //If BMI is greater than or equal to 18.5 but less than 25
            {
                BMI_output = "Normal";
            }
            if (userBMI >= 25 && userBMI < 30) //If BMI is greater than or equal to 25 but less than 30
            {
                BMI_output = "Overweight";
            }
            if (userBMI >= 30) //If BMI is greater than or equal to 30
            {
                BMI_output = "Obese";
            }
            Console.WriteLine("\n Body Mass Index (BMI): " + userBMI + "\n You are considered \"" + BMI_output + "\"");
        }

        static void Main(string[] args)
            {            
                while (true)
                {
                    Console.Clear();
                    string one = "         City Gym Membership Form";
                    string two = "\n Please select one of the following options: \n\n [1] Calculate your BMI\n [2] View membership rates\n [3] Exit application";               
                    Console.WriteLine(one + two);

                    string sel = Console.ReadLine();

                    if (sel == "1") // Calculate BMI
                    {
                        Console.Clear();
                        CalculateBMI();
                    }
                    else if (sel == "2") // Membership Details
                    {
                        Console.Clear();
                        MembershipDetails();
                        
                    }
                    else if (sel == "3") // Exit Application
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        UnknownCommand(sel);
                    }
                    {
                        Console.WriteLine("\n\n Press enter to return to the main menu. ");
                        Console.ReadKey();
                    }
                }
            }
        }
    }