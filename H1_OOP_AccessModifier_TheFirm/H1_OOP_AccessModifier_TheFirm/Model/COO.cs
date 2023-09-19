using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_AccessModifier_TheFirm.Model
{
    internal class COO: BoardOfDirector
    {
        internal COO(string firstName, string lastName, string department, string cprNr, float salary, string title, string tel, string email) : base(firstName, lastName, department, cprNr, salary, title, tel, email)
        {

        }

    }
}
