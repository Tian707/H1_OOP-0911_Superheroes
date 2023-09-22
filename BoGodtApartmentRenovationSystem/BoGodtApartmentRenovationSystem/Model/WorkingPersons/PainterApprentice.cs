using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtApartmentRenovationSystem.Model.WorkingPersons
{
    internal class PainterApprentice: Apprentice
    {

        internal PainterApprentice(
          LaborType laborType,
          Category category,
          Gender gender,
          string? name,
          string? company,
          double workingHours,
          double hourlyWage,
          double salary,
          Journeyman journeyman)
          : base(laborType, category, gender, name, company, workingHours, hourlyWage, salary, journeyman)
        {
           
        }
       internal override string Print()
        {
            return $"I am a {Category} apprentice, my journeyman is {Journeyman}.";
        }

        public override Journeyman GetMyJourneyman()
        {
            return Journeyman;
        }
        public override string WorkAlongsideJourneyman()
        {
            return $"I am working alongside my journeyman {Journeyman}.";
        }

    }
}
