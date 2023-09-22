using BoGodtApartmentRenovationSystem.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtApartmentRenovationSystem.Model.WorkingPersons
{
    internal abstract class Journeyman: Labor, IJourneyman
    {
        // fields
        protected List<Apprentice> apprentices;

        internal Journeyman(
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
            this.hourlyWage = 1000;

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
        public abstract List<IApprentice> GetApprentices()
        {
            return apprentices.Where(category => category is Category.Painter);
        }



    }
}
