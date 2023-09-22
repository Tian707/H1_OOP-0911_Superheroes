using BoGodtApartmentRenovationSystem.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtApartmentRenovationSystem.Model.WorkingPersons
{
    internal class Painter: Journeyman
    {
        internal Painter(
         LaborType laborType,
         Category category,
         Gender gender,
         string? name,
         string? company,
         double workingHours,
         double hourlyWage,
         double salary)
         : base(laborType, category, gender, name, company, workingHours, hourlyWage, salary)
        {
            
        }

        public override List<IApprentice> GetApprentices()
        {
            return apprentices.Where(apprentice => Apprentice.Category == Category.Painter).ToList();
        }
        internal override string Print()
        {
            return $"I am a {Category} journeyman.";
        }

    }
}
