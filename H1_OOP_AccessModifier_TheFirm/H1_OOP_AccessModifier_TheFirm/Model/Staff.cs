using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_AccessModifier_TheFirm.Model
{
    internal class Staff :Employee
    {
       
        internal Staff(string firstName, string lastName, string department, string cprNr, float salary) :base(firstName, lastName, department, cprNr, salary)
        {

        }
        

        

    }
}
