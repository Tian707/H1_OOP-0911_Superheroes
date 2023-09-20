using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_AccessModifier_TheFirm.Model
{
    internal abstract class Worker : Employee
    {
       
        internal Worker(string department, float salary) :base(department, salary)
        {

        }
        
    }
}
