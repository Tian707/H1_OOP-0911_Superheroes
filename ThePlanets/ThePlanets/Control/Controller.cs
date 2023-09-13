using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePlanets.Model;
using ThePlanets.View;

namespace ThePlanets.Control
{
    internal class Controller
    {
        


        public void Start()
        {
            // 2. Initialize a new SolarSystem instance
            // when newSystem is created, a list of planets is created as a property (Planet)
            SolarSystem newSystem = new SolarSystem();

            // 2. Create 8 planets:
            Planet Mercury = new Planet("Mercury", 0.330f, 4879, 5427, 3.7f, 1407.6f, 4222.6f, 57.9f, 88.0f, 47.4f, 167, 0, false);
            Planet Earth = new Planet("Earth", 5.97f, 12756, 5514, 9.8f, 23.9f, 24.0f, 149.6f, 365.2f, 29.8f, 15, 1, false);
            Planet Mars = new Planet("Mars", 0.642f, 6792, 3933, 3.7f, 24.6f, 24.7f, 227.9f, 687.0f, 24.1f, -65, 2, false);
            Planet Jupiter = new Planet("Jupiter", 1898f, 142984, 1326, 23.1f, 9.9f, 9.9f, 778.6f, 4331f, 13.1f, -110, 67, true);
            Planet Saturn = new Planet("Saturn", 568f, 120536, 87, 9.0f, 10.76f, 10.7f, 1433.5f, 10747f, 9.7f, -140, 62, true);
            Planet Uranus = new Planet("Uranus", 86.8f, 51118, 1271, 8.7f, -17.2f, 17.2f, 2872.5f, 30589f, 6.8f, -195, 27, true);
            Planet Neptune = new Planet("Neptune", 102f, 49528, 1638, 11.0f, 16.1f, 16.1f, 4495.1f,59.8f, 5.4f, -200, 14, true);
            Planet Pluto = new Planet("Pluto", 0.0146f, 2370, 2095, 0.7f, -153.3f, 153.3f, 5906.4f,90.56f, 4.7f, -225, 5, false);

            // 2. Add Planet objects to SolarSystem, use Property List's Add()method to add new Planet to list
            newSystem.Planets.Add(Mercury);
            newSystem.Planets.Add(Earth);
            newSystem.Planets.Add(Mars);
            newSystem.Planets.Add(Jupiter);
            newSystem.Planets.Add(Saturn);
            newSystem.Planets.Add(Uranus);
            newSystem.Planets.Add(Neptune);
            newSystem.Planets.Add(Pluto);
            
            // 3. Print all objects in the list
            // Display.Print(newSystem.ToString());

            // 4. Create a new Planet Venus
            Planet Venus = new Planet("Venus", 4.87f, 12104, 5243, 8.9f, -5832.5f, 2802.0f, 108.2f, 224.7f, 35.0f, 464, 0, false);

            // 4. Insert Venus to SolarSystem before Earth: first find index of Earth, thn insert Venus
            int insertIndex = newSystem.Planets.IndexOf(Earth);
            newSystem.Planets.Insert(insertIndex, Venus);

            // 5. Print new list with Venus
            // Display.Print(newSystem.ToString());

            // 6. remove Pluto using if statement
            for (int i = newSystem.Planets.Count - 1; i >= 0 ; i--)
            {
                if(newSystem.Planets[i].Name == "Pluto")
                {
                    newSystem.Planets.RemoveAt(i);
                }
            }
            Display.Print(newSystem.ToString());

            // 7. Insert Pluto again
            newSystem.Planets.Add(Pluto);
            
            // 8. Print list elements count to the console
            int count = newSystem.Planets.Count;
            Display.Print(count.ToString());

            // 9. Get a list of cold planets 
            List<Planet> coldPlanets = Planet.GetColdPlanets(newSystem.Planets);
            foreach (Planet p in coldPlanets)
            {
                Display.Print(p.Name.ToString());
            }

            //10.  Get a list of planets with a diameter between 10000km and 49999km
            List<Planet> insideDiameterRangePlanets = Planet.GetInsideDiameterRangePlanets(newSystem.Planets);
            foreach (Planet p in insideDiameterRangePlanets)
            {
                Display.Print(p.Name.ToString());
            }

            // 11. Remove all from list
            insideDiameterRangePlanets.Clear();
        }
    }
}
