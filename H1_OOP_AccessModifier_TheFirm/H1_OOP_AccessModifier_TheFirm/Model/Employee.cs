using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_AccessModifier_TheFirm.Model
{
     internal abstract class Employee
      {
        private string department;
        private float salary;

        protected string Department { get => department; private set => department = value; }
        protected float Salary { get => salary; private set => salary = value; }

 /// <summary>
            /// When this class is inherited by derived classes
            /// protected class -- no access, out of this scope, protected == private
            /// internal, can inherited by a new class outside this scope
            /// </summary>
            /// <param name="department"></param>
            /// <param name="salary"></param>
        protected Employee(string department, float salary)
        {
            Department = department;
            Salary = salary;
        }

        public abstract string ToString();
        

    }
}
