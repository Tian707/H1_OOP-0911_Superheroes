﻿using H1_OOP_TheQueue.Model;
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
        public static string GetUserChoice()
        {
            return Console.ReadLine();
        }
        public static string GetNewPatientName()
        {
            Print("Enter the name of the patient:");
            return Console.ReadLine();
        }
        public static string AskPatientNameForSearch()
        {
            Print("Enter the name of the patient you want to search:");
            return Console.ReadLine();
        }

        public static string AskIfDeleteFirstPatient()
        {
            Console.WriteLine("Do you want to delete the first patient? Y/N");
            return Console.ReadLine();
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
