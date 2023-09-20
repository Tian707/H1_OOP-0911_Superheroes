using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_AnimalFarm.Model
{
    internal class AnimalStation
    {

        /* properties create a private backing field for lists. 
         * properties FarmAnimals and LeftAnimals internal with private setters, 
         * which allows you to modify the lists within the AnimalStation class 
         * but prevents external code from changing them directly.
         */
        internal List<FarmAnimal> FarmAnimals { get; private set; }
        internal List<FarmAnimal> LeftAnimals { get; private set; }

        //internal List<FarmAnimal>? FarmAnimals
        //{
        //    get { return farmAnimals; }
        //    private set { farmAnimals = value; }
        //}

        //internal List<FarmAnimal>? LeftAnimals
        //{
        //    get { return farmAnimals; }
        //    private set { farmAnimals = value; }
        //}


        internal AnimalStation() 
        {
            FarmAnimals = new List<FarmAnimal>();
            LeftAnimals = new List<FarmAnimal>();
        }

        internal string AddAnimal(FarmAnimal farmAnimal)
        {
            FarmAnimals.Add(farmAnimal);
            return "Farm animal added to the FarmAnimals list!";
        }
        /// <summary>
        /// To remove an animal:
        /// 1. list.Count > 0
        /// 2. list contains the specific object
        /// 3. remove it from FarmAnimals
        /// 4. add to LeftAnimals
        /// 5. show a message
        /// </summary>
        /// <param name="farmAnimal"></param>
        internal string DeleteAnimal(FarmAnimal farmAnimal)
        {
            if(FarmAnimals.Count < 1)
            {
                return "Your farm is empty!";
            }
           
            if(!FarmAnimals.Contains(farmAnimal))
            {
                return "The animal is not in your farm now.";
            }

            FarmAnimals.Remove(farmAnimal);
            LeftAnimals.Add(farmAnimal);
            return $"The animal is removed from your FarmAnimals list to the LeftAnimals list.";
        }

        /// <summary>
        /// Get the age of all animals that left the station
        /// </summary>
        /// <returns></returns>
        internal string GetAllLeftAnimalAgeInMonths()
        {
            if (LeftAnimals.Count < 1)
            {
                return "No animal have left your farm yet!";
            }
            StringBuilder stringBuilder = new StringBuilder();
            foreach(var farmAnimal in LeftAnimals)
            {
                stringBuilder.AppendLine(farmAnimal.AgeInMonths.ToString() + " months");
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Get elements of a specific list
        /// </summary>
        /// <param name="animalList"></param>
        /// <returns></returns>
        public string ToString(List<FarmAnimal> animalList)
        {
            StringBuilder sb = new StringBuilder(); 
            if (animalList == null)
            {
                return "Your farm is empty.";
            }
            else
            {
                foreach (var farmAnimal in animalList)
                {
                    sb.AppendLine(farmAnimal.ToString());
                    //StringBuilder.AppendLine method expects a string as an argument
                    //so use object.ToString()
                }
            }
            return sb.ToString();
        }


    }
}
