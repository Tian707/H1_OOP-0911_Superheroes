using H1_OOP_TheQueue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace H1_OOP_TheQueue.View
{
    internal class Display
    {
        private const string artTitle = @"████████╗██╗  ██╗███████╗     ██████╗ ██╗   ██╗███████╗██╗   ██╗███████╗
╚══██╔══╝██║  ██║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██║   ██║██╔════╝
   ██║   ███████║█████╗      ██║   ██║██║   ██║█████╗  ██║   ██║█████╗  
   ██║   ██╔══██║██╔══╝      ██║▄▄ ██║██║   ██║██╔══╝  ██║   ██║██╔══╝  
   ██║   ██║  ██║███████╗    ╚██████╔╝╚██████╔╝███████╗╚██████╔╝███████╗
   ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚══▀▀═╝  ╚═════╝ ╚══════╝ ╚═════╝ ╚══════╝
                                                                        ";
        public static void Print(string str)
        {
            Console.WriteLine(str);
        }

        public static void ShowMenu()
        {

            Console.WriteLine();
            Console.WriteLine(artTitle);
            Console.WriteLine("========================================================================");
            Console.WriteLine("                      H1 Queue Operations Menu");
            Console.WriteLine("========================================================================");
            Console.WriteLine("1. Add patient");
            Console.WriteLine("2. Delete patient");
            Console.WriteLine("3. Show the number of patients");
            Console.WriteLine("4. Show min and max patients");
            Console.WriteLine("5. Find an patient");
            Console.WriteLine("6. Print all patients");
            Console.WriteLine("7. Exit");
            Console.WriteLine("\nEnter the index of your choice:");
        }
        /// <summary>
        /// Handle the case where Console.ReadLine() returns null,
        /// returns an error message.
        /// This helper method encapsulates null reference fejl
        /// and is used in all input-related methods
        /// </summary>
        /// <returns></returns>
        public static string GetUserInput()
        {
            string? userInput = Console.ReadLine();

            /* Validation beneath is unnecessary, 
             * 
            //if (userInput == null)
            //{
            //    return "Error: Unable to read user input.";
            //}
             * 
             * 
             * when it return "Error: Unable to read user input."
             * in this:
             * while (!int.TryParse(Display.GetUserInput(), out int userChoice) || userChoice < 1 || userChoice > 7)
                {
                    string msg = "Invalid choice, please enter a number between 1 and 7.";
                    Display.Print(msg);
                }
            * it always fails here: int.TryParse(Display.GetUserInput()
            */


            
            return userInput;
        }
        //public static string GetUserChoice()
        //{
        //    return GetUserInput();
        //}
        public static string GetNewPatientName()
        {
            Print("Enter the name of the patient:");
            return GetUserInput();
        }
        public static string AskPatientNameForSearch()
        {
            Print("Enter the name of the patient you want to search:");
            return GetUserInput();
        }

        public static string AskIfDeleteFirstPatient()
        {
            Console.WriteLine("Do you want to delete the first patient? Y/N");
            return GetUserInput();
        }
        public static void ExitProgram()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        public static void BackToMainMenu()
        {
            Console.WriteLine("Press any key to back to the main menu.");
            Console.ReadKey();
        }
        public static void RefreshConsoleWindow()
        {
            Console.Clear();
        }
    }
}
