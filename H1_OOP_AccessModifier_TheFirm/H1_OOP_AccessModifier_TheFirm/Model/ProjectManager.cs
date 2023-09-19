using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_AccessModifier_TheFirm.Model
{
    internal class ProjectManager : Manager
    {
        private string? _email;

        public string? Email { get => _email; private set => _email = value; }
        internal ProjectManager( string firstName, string lastName, string cprNr, string tel, string email) :base(firstName, lastName, cprNr, tel) 
        { 
            Email = email;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Email: {Email}";
        }
    }
}
