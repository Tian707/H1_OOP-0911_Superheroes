using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_Library.View
{
    public class Display
    {

        public static void Print(string str)
        {
            Console.WriteLine(str);
        }
        public static string BookWantToBorrow()
        {
            Print("Please enter the name of the book:");
            string? bookToRetrieve = Console.ReadLine();
            return bookToRetrieve;


            //char? ch = 's';

            //char ch1 = ch;
            //char ch2 = (char)ch;

        
        }



    }
}
