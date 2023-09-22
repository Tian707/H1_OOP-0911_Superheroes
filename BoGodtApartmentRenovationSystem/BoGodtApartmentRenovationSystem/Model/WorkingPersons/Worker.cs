using BoGodtApartmentRenovationSystem.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtApartmentRenovationSystem.Model.WorkingPersons
{
    internal class Worker : Labor, IWorker
    {
        internal Worker(
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
            hourlyWage = 450;
        }
        internal override double GetWorkingHours() 
        {
            return WorkingHours;
        }
        internal override double GetSalary()
        {
            return HourlyWage * WorkingHours;
        }

        internal override string Print()
        {
            return "I am a worker.";
        }

        public string TearDown()
        {
            return "I remove the old floor.";
        }
        public string CleanUp()
        {
            return "I clean up.";
        }
        public string IncidentalWork()
        {
            return "I get som extra work done.";
        }
    }
}

