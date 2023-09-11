using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_OOP_Superheroes.Modul
{
    public class SuperHero
    {
        /// <summary>
        /// Sttributes (Fields): 
        /// variables declared within a class, represent the state or data of an object of this class.
        /// typically private or protected to encapsulate the internal state of the class and provide controlled access to it
        /// </summary>
        private string _name = "";
        private string _secretIdentity = "";
        private string _costume = "";
        private int _lifePercentage = 100;
        // Use the Skill class
        private Skill _heroSkill;


        /// <summary>
        /// Properties:
        /// provide controlled access to field, define custom get and set methods
        /// Here are properties of a superHero
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string SecretIdentity
        {
            get { return _secretIdentity; }
            set { _secretIdentity = value; }
        }
        public string Costume
        {
            get { return _costume; }
            set { _costume = value; }
        }
        public int LifePercentage
        {
            get { return _lifePercentage; }
            set { _lifePercentage = value; }
        }
        public Skill HeroSkill
        {
            get { return _heroSkill;  }
            set { _heroSkill = value; }
        }

        /// <summary>
        /// A superHero attacks enemy with a specific skill
        /// tells the damage on enemy and comsumption of the superhero's life
        /// </summary>
        public void Attack()
        {
            LifePercentage -= HeroSkill.ConsumptionPercentage;
            Console.WriteLine($"{Name} attacks with {HeroSkill.Name}, enemy life - {HeroSkill.DamagePercentage}%.");
            Console.WriteLine($"{Name} life: {LifePercentage}%.");
        }
        
        /// <summary>
        /// Present a superhero with detailed information
        /// Also include his/her skill 
        /// </summary>
        public void PresentSuperHero()
        {
            Console.WriteLine($"Superhero: {Name}");
            Console.WriteLine($"Secret Identity: {SecretIdentity}");
            Console.WriteLine($"Costume: {Costume}");
            Console.WriteLine("Superhero Skill:");
            Console.WriteLine($"Skill Name: {HeroSkill.Name}");
            Console.WriteLine($"Skill Description: {HeroSkill.Description}");
            Console.WriteLine($"Skill Equipment: {HeroSkill.Equipment}");
            Console.WriteLine($"Skill Level: {HeroSkill.SkillLevel}");
            Console.WriteLine($"Skill Damage Percentage: {HeroSkill.DamagePercentage}%");
            Console.WriteLine($"Skill Consumption Percentage: {HeroSkill.ConsumptionPercentage}%");
        }

    }
}
