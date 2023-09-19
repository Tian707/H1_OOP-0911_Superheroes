using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_AccessModifier_TheFirm.Model
{
    internal class CEO : BoardOfDirector
    {
        internal CEO(string firstName, string lastName, string department, string cprNr, float salary, string title, string tel, string email) : base(firstName, lastName, department, cprNr, salary, title, tel, email)
        {

        }
        public void AddChief(DepartmentChief chief)
        {
            Chiefs.Add(chief);
        }public void AddManager(Manager manager)
        {
            Managers.Add(manager);
        }

    }
}
