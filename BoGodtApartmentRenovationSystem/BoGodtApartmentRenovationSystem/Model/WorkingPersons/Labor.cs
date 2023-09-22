using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtApartmentRenovationSystem.Model.WorkingPersons
{
    internal abstract class Labor
    {
        // fields
        protected LaborType laborType;
        protected Category category;
        protected Gender gender;
        protected string? name;
        protected string? company;
        protected double workingHours;
        protected double hourlyWage;
        protected double salary;

        // properties
        protected LaborType LaborType { get => laborType; }
        protected Category Category { get => category; }
        protected Gender Gender { get => gender; }
        protected string? Name { get => name; }
        protected string? Company { get => company; }
        public double WorkingHours { get => workingHours; private set => workingHours = value; }
        public double HourlyWage { get => hourlyWage; private set => hourlyWage = value; }
        protected double Salary { get => salary; private set => salary = value; }

        


        //constructor
        protected Labor(LaborType laborType, Category category, Gender gender, string? name, string? company, double workingHours, double hourlyWage, double salary)
        {
            this.laborType = laborType;
            this.category = category;
            this.gender = gender;
            this.name = name;
            this.company = company;
            this.workingHours = workingHours;
            this.hourlyWage = hourlyWage;
            this.salary = salary;

        }

        //methods:
        internal abstract double GetWorkingHours();
        internal abstract double GetSalary();
        internal abstract string Print();


    }

    enum LaborType { Worker, Apprentice, Journeyman }
    enum Category { Worker, Carpenter, Painter }
    enum Gender { Male, Female }


}
