using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_AccessModifier_TheFirm.Model
{
    internal class Manager : Employee
    {

        
        protected string? _tel;
        internal string? Tel { get => _tel; private set => _tel = value; }


        internal Manager(string firstName, string lastName, string cprNr, string tel) : base(firstName, lastName, cprNr)
        {
            Tel = tel;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, \nTel: {Tel}";
        }

    }
}
