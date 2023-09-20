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
        protected List<DepartmentChief> Chiefs { get => chiefs; private set => chiefs = value; }

        internal BoardOfDirector(string firstName, string lastName, string department, string cprNr, float salary, string title, string tel, string email) : base(firstName, lastName, department, cprNr, salary, title, tel, email)
        {
            Chiefs = new List<DepartmentChief>();
        }
        public  string GetChiefList()
        {
            StringBuilder sb = new StringBuilder();
            foreach (object obj in Chiefs)
            {
                sb.Append(obj.ToString());
            }
            return sb.ToString();
        }
        public string GetManagerList()
        {
            StringBuilder sb = new StringBuilder();
            foreach (object obj in Managers)
            {
                sb.Append(obj.ToString());
            }
            return sb.ToString();
        }
    }
}
