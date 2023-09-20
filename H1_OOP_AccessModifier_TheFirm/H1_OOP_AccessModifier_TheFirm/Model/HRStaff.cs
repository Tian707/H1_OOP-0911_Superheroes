using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_AccessModifier_TheFirm.Model
{
    internal class HRStaff : Worker
    {
        private List<Worker> staffs;
        internal HRStaff(string firstName, string lastName, string department, string cprNr, float salary) :base(firstName, lastName, department, cprNr, salary)
        {
            staffs = new List<Worker>();
        }


        public void AddStaff(Worker staff)
        {
            staffs.Add(staff);
        }

        public string GetStaffs()
        {
            StringBuilder sb = new StringBuilder();
           
            
                foreach (object obj in staffs)
                {
                    sb.Append(obj.ToString());
                }
                return sb.ToString();

            
        }

    }
}
