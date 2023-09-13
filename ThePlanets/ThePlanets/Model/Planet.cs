using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ThePlanets.Model
{
    internal class Planet
    {
        // Attributes for instance of a planet
        private string _name;
        private float _mass;
        private int _diameter;
        private short _density;
        private float _gravity;
        private float _rotationPeriodInHour;
        private float _lengthOfDayInHour;
        private float _distanceFromSun;
        private float _orbitalPeriod;
        private float _orbitalVelocity;
        private short _meanTemperature;
        private Byte _numberOfMoons;
        private bool _hasRingSystem;

        public string Name { get => _name; private set => _name = value; }

        /// <summary>
        /// Constructor for an object Planet
        /// </summary>
        public Planet(string name, float mass, int diameter, short density, float gravity, float rotationPeriodInHour, float lengthOfDayInHour, float distanceFromSun,
            float orbitalPeriod, float orbitalVelocity, short meanTemperature, Byte numberOfMoons, bool hasRingSystem)
        {
            _name = name;
            _mass = mass;
            _diameter = diameter;
            _density = density;
            _gravity = gravity;
            _rotationPeriodInHour = rotationPeriodInHour;
            _lengthOfDayInHour = lengthOfDayInHour;
            _distanceFromSun = distanceFromSun;
            _orbitalPeriod = orbitalPeriod;
            _orbitalVelocity = orbitalVelocity;
            _meanTemperature = meanTemperature;
            _numberOfMoons = numberOfMoons;
            _hasRingSystem = hasRingSystem;
        }

        

        /// <summary>
        /// // Override the ToString method to provide a custom string representation of object Planet
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Planet Name: {_name}\n" +
                  $"Mass: {_mass} (1024kg)\n" +
                  $"Diameter: {_diameter} km\n" +
                  $"Density: {_density} kg/m^3\n" +
                  $"Gravity: {_gravity} m/s^2\n" +
                  $"Rotation Period: {_rotationPeriodInHour} hours\n" +
                  $"Length of Day: {_lengthOfDayInHour} hours\n" +
                  $"Distance From Sun: {_distanceFromSun} (106km)\n" +
                  $"Orbital Period: {_orbitalPeriod} days\n" +
                  $"Orbital Velocity: {_orbitalVelocity} km/s\n" +
                  $"Mean Temperature: {_meanTemperature}°C\n" +
                  $"Number of Moons: {_numberOfMoons}\n" +
                  $"Has Ring System: {_hasRingSystem}\n";
        }
        /// <summary>
        /// A static method which takes a list of planets as a parameter.<br/>
        /// Use LINQ's Where method to filter the planets based on the condition p.MeanTemperature < 0.<br/>
        /// Convert the filtered result back into a list using the ToList method.<br/>
        /// Inside the Planet class:<br/>
        /// Focus on the attribute of Planet<br/>
        /// The Planet class is responsible for its own properties and behavior.
        /// </summary>
        /// <param name="planets"></param>
        /// <returns></returns>
        public static List<Planet> GetColdPlanets(List<Planet> planets) 
        {
            return(planets.Where(planet => planet._meanTemperature < 0)).ToList();
        }

        /// <summary>
        /// Filter the planets whose diameter is between 10000 and 49999
        /// </summary>
        /// <param name="planets"></param>
        /// <returns></returns>
        public static List<Planet> GetInsideDiameterRangePlanets(List<Planet> planets)
        {
            return (planets.Where(planet => planet._diameter > 10000).Where(planet => planet._diameter < 50000)).ToList();
        }


    }
}
