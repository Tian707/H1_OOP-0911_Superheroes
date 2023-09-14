using H1_OOP_TheQueue.Model;
using H1_OOP_TheQueue.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_TheQueue.Controller
{
    internal class Control
    {
        // Create an instance of Pharmacy and prepare the console window
        // Now we also have an empty PatientQueue
        private static object pharmacy;

        public static void Open()
        {
            Pharmacy pharmacy = new Pharmacy();

            while (true)
            {
                // Prepare the console window with menu
                Display.RefreshConsoleWindow();
                Display.ShowMenu();

                // Validate user choice, tryParse userinput to an int
                int userChoice;
                while (!int.TryParse(Display.GetUserChoice(), out userChoice) || userChoice < 1 || userChoice > 7)
                {
                    string msg = "Invalid choice, please enter a number between 1 and 7.";
                    Display.Print(msg);
                }

                switch (userChoice)
                {
                    case 1:
                        {
                            //string newPatientName = Display.GetNewPatientName();
                            //pharmacy.AddNewPatientToQueue(newPatientName);
                            //Display.Print($"{newPatientName} added to the queue.");
                            //return;
                            Display.RefreshConsoleWindow();
                            Display.Print(pharmacy.AddNewPatientToQueue(Display.GetNewPatientName()));
                            Display.BackToMainMenu();

                            break;
                        }

                    case 2:
                        {
                            Display.RefreshConsoleWindow();
                            string deletePatient = "";

                            // Keep asking until the user input is either Y or N
                            
                            while (deletePatient.ToUpper() != "Y" && deletePatient.ToUpper() != "N")
                            {
                                deletePatient = Display.AskIfDeleteFirstPatient();
                            }
                            if (deletePatient.ToUpper() == "Y")
                            { 
                                Display.Print(pharmacy.RemoveFirstPatient()); 
                            }
                            Display.BackToMainMenu();
                            break;
                        }

                    case 3:
                        {
                            Display.RefreshConsoleWindow();
                            Display.Print(pharmacy.ShowQueueCount().ToString());
                            Display.BackToMainMenu();
                            break;
                        }
                    case 4:
                        {
                            Display.RefreshConsoleWindow();
                            Display.Print(pharmacy.MinMax());
                            Display.BackToMainMenu();
                            break;
                        }
                    case 5:
                        {
                            Display.RefreshConsoleWindow();
                            Display.Print(pharmacy.FindAPatient(Display.AskPatientNameForSearch()));
                            Display.BackToMainMenu();
                            break;
                        }
                    case 6:
                        {
                            Display.RefreshConsoleWindow();
                            Display.Print(pharmacy.GetAllPatient());
                            Display.BackToMainMenu();

                            break;
                        }
                    case 7:
                        {
                            Display.RefreshConsoleWindow();
                            Display.ExitProgram();
                            Environment.Exit(0);
                            break;
                        }

                }

            }


        }
    }
}
