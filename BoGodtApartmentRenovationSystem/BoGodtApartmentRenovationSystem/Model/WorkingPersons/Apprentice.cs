using BoGodtApartmentRenovationSystem.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtApartmentRenovationSystem.Model.WorkingPersons
{
    internal abstract class Apprentice: Labor, IApprentice
    {
        // fields
        protected Journeyman journeyman;

        internal Journeyman Journeyman { get => journeyman; private set => journeyman = value; }

        internal Apprentice(
          LaborType laborType,
          Category category,
          Gender gender,
          string? name,
          string? company,
          double workingHours,
          double hourlyWage,
          double salary,
          Journeyman journeyman)
          : base(laborType, category, gender, name, company, workingHours, hourlyWage, salary)
        {
            this.hourlyWage = 650;
            Journeyman = journeyman;
        }
        internal override double GetWorkingHours()
        {
            return WorkingHours;
        }
        internal override double GetSalary()
        {
            return HourlyWage * WorkingHours;
        }


        internal override abstract string Print();
        public abstract Journeyman GetMyJourneyman();
        public abstract string WorkAlongsideJourneyman();
        
    }
}
