using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_OOP_Superheroes.Modul
{
    public class Skill
    {
        /// <summary>
        /// Attributes of skills of a superhero
        /// </summary>
        private string _name = "";
        private string _description = "";
        private string? _equipment;
        private int _skillLevel;
        private int _damagePercentage;
        private int _consumptionPercentage;

        /// <summary>
        /// Properties for a super power skill, including introduction
        /// as well as its damage on an enemy and consumption on the superhero
        /// </summary>
        public string Name
        { 
            get { return _name; } 
            set { _name = value; } 
        }
        public string Description
        {
            get { return _description; }
            set 
            {
                if (value == null)
                {
                    _description = "None";
                }
                else
                {
                    _description = value;
                }
            }
        }
        /// <summary>
        /// tried some costum logic on _equipment<br/>
        /// </summary>
        public string Equipment
        {
            get { return _equipment; }
            set
            {
                if (value == null)
                {
                    _equipment = "No equipment.";
                }
                else
                {
                    _equipment = value;
                }
            }
        }
        public int SkillLevel
        {
            get { return _skillLevel; }
            set { _skillLevel = value; }
        }
        public int DamagePercentage
        {
            get { return _damagePercentage; }
            set { _damagePercentage = value; }
        }
        public int ConsumptionPercentage
        {
            get { return _consumptionPercentage; }
            set { _consumptionPercentage = value; }
        }
        
    }
}
