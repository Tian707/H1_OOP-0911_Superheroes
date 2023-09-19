using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_AccessModifier_TheFirm.Model
{
     internal class Employee
    {
        protected string? _firstName;
        protected string? _lastName;
        protected string? _cprNr;

        internal string? FirstName { get => _firstName; private set => _firstName = value; }
        internal string? LastName { get => _lastName; private set => _lastName = value; }
        internal string? CprNr { get => _cprNr; private set => _cprNr = value; }
       

       /// <summary>
       /// When this class is inherited by derived classes
       /// protected class -- no access, out of this scope, protected == private
       /// internal, can inherited by a new class outside this scope
       /// </summary>
       /// <param name="firstName"></param>
       /// <param name="lastName"></param>
       /// <param name="cprNr"></param>
        internal Employee(string firstName, string lastName, string cprNr)
        {
            FirstName = firstName;
            LastName = lastName;
            CprNr = cprNr;
        }

        public override string ToString() 
        {
            return $"\nName: {FirstName} {LastName}, CPR Number: {CprNr}";
        }

    }
}
