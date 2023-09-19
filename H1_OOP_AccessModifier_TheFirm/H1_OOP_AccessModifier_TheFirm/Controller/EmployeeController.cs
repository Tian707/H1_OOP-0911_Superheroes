using H1_OOP_AccessModifier_TheFirm.Model;
using H1_OOP_AccessModifier_TheFirm.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_AccessModifier_TheFirm.Controller
{
    public class EmployeeController
    {


        public void GetEmployees()
        {
            Sweeper lis = new Sweeper("Lis", "Hanse", "695254");
            Manager mng = new Manager("Dan", "Nilsen", "6254780", "25256565");
            ProjectManager pm = new ProjectManager("Lucy", "Green", "2856565", "65659876", "LG@zolaho.dk");

            Display show = new Display();
            show.Print(lis.ToString());
            show.Print(mng.ToString());
            show.Print(pm.ToString());

            Console.WriteLine(typeof(Sweeper) == typeof(Manager)); 

        }

        //public List<Employee> CreateEmployee()
        //{

        //}
        //public void ShowEmployeeInfo()
        //{
        //    Display show = new Display();
        //    show.Print(lis.ToString());

        //}
    }
}
