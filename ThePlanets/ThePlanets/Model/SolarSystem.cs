using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePlanets.Control;

namespace ThePlanets.Model
{
    internal class SolarSystem
    {
        private List<Planet> _planets;

        /// <summary>
        /// Public property to get list from Controller
        /// Declare a List
        /// </summary>
        public List<Planet> Planets { get => _planets; private set => _planets = value; }


        /// <summary>
        /// Constructor
        /// Initialize the list
        /// </summary>
        public SolarSystem()
        {
            _planets = new List<Planet>();
        }

        /// <summary>
        /// Create new Planet
        /// ?? why did I create this when I can create a new planet in Controller?
        /// </summary>
        /// <param name="name"></param>
        /// <param name="mass"></param>
        /// <param name="diameter"></param>
        /// <param name="density"></param>
        /// <param name="gravity"></param>
        /// <param name="rotationPeriodInHour"></param>
        /// <param name="lengthOfDayInHour"></param>
        /// <param name="distanceFromSun"></param>
        /// <param name="orbitalPeriod"></param>
        /// <param name="orbitalVelocity"></param>
        /// <param name="meanTemperature"></param>
        /// <param name="numberOfMoons"></param>
        /// <param name="hasRingSystem"></param>
        /// <returns></returns>
        public Planet CreateNewPlanet(string name, float mass, int diameter, short density, float gravity, float rotationPeriodInHour, float lengthOfDayInHour, float distanceFromSun,
          float orbitalPeriod, float orbitalVelocity, short meanTemperature, Byte numberOfMoons, bool hasRingSystem)
        {
            Planet newPlanet = new Planet(name, mass, diameter, density, gravity, rotationPeriodInHour, lengthOfDayInHour, distanceFromSun,
            orbitalPeriod, orbitalVelocity, meanTemperature, numberOfMoons, hasRingSystem);
            return newPlanet;
        }
        public void AddToList(Planet planet)
        {
            _planets.Add(planet);
        } 
        
        public List<Planet> GetList()
        {
            return _planets;
        }
        /// <summary>
        /// save all data of objects in the list into a StringBuilder
        /// then convert to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Planet planet in _planets)
            { 
                sb.AppendLine(planet.ToString()); 
            }
            return sb.ToString();
        }
    }
}
