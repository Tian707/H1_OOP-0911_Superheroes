using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_AccessModifier_TheFirm.Model
{
    internal class DepartmentChief : Manager
    {
        private string _email;
        private List<Manager> managers;

        internal string Email { get => _email; private set => _email = value; }
        protected List<Manager> Managers { get => managers; private set => managers = value; }

        internal DepartmentChief(string firstName, string lastName, string department, string cprNr, float salary, string title, string tel, string email) : base(firstName, lastName, department, cprNr, salary, title, tel)
        { 
            Email = email;
            managers = new List<Manager>();
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Email: {Email}";
        }
        
    }
}
