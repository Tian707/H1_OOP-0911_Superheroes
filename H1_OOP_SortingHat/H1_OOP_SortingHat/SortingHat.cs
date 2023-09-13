using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_SortingHat
{
    public class SortingHat
    {

        // Define an enum for the Hogwarts Houses
        enum Houses { Gryffindor, Hufflepuff, Ravenclaw, Slytherin }
        private Random random = new Random();
        public SortingHat()
        {

        }

        private Houses FindingHouse()
        {
            // Generate a random index for selecting a house
            int randomIndex = random.Next(0, Enum.GetValues(typeof(Houses)).Length);
            return (Houses) randomIndex;
        }

        public void SayResult(string studentName)
        {
            Houses studentHouse = FindingHouse();
            Console.WriteLine($"{studentName} belongs to the House of {studentHouse}.");
        }
    }
}


      
    