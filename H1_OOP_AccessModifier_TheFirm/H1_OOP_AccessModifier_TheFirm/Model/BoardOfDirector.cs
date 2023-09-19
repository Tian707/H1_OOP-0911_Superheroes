using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_AccessModifier_TheFirm.Model
{
    internal class BoardOfDirector : DepartmentChief
    {
        private List<DepartmentChief> chiefs;
        public List<DepartmentChief> Chiefs { get => chiefs; private set => chiefs = value; }

        public BoardOfDirector(string firstName, string lastName, string department, string cprNr, float salary, string title, string tel, string email) : base(firstName, lastName, department, cprNr, salary, title, tel, email)
        {
            Chiefs = new List<DepartmentChief>();
        }
        public  string GetList()
        {
            StringBuilder sb = new StringBuilder();
            foreach (object obj in Chiefs)
            {
                sb.Append(obj.ToString());
            }
            return sb.ToString();
        }
    }
}
