using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_AccessModifier_TheFirm.Model
{
    internal class Manager : Employee
    {

        protected string _tel;
        private string title;
        internal HRStaff hrstaff { get; }


        internal string Tel { get => _tel; private set => _tel = value; }
        protected string Title { get => title; private set => title = value; }

        internal Manager(string firstName, string lastName, string department, string cprNr, float salary, string title, string tel) : base(firstName, lastName, department, cprNr, salary)
        {
            Title = title;
            Tel = tel;

        }

        public override string ToString()
        {
            return $"{base.ToString()} {title}, \nTel: {Tel}";
        }

        public virtual string GetStaffs()
        {
            
            if (hrstaff != null)
            {
                
                return hrstaff.GetStaffs();
            }
            else
            {
                return "HRStaff instance not set.";
            }
        }

    }
}
