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
        // Initialize objects
        private CEO ceo;
        private COO coo;
        private CFO cfo;

        // Chiefs:
        private DepartmentChief itChief;
        private DepartmentChief financeChief;


        // Managers
        private Manager itDevManager;
        private Manager itTestManager;
        private Manager itProjectManager;

        private Manager budgetManager;
        private Manager innovationManager;

        // HR Staff
        private HRStaff hrStaff;

        // It staff
        private Staff itDevStaff1;
        private Staff itDevStaff2;
        private Staff itDevStaff3;
        private Staff itTestStaff1;
        private Staff itTestStaff2;
        private Staff itTestStaff3;
        private Staff itProjectStaff1;
        private Staff itProjectStaff2;
        private Staff itProjectStaff3;

        private Staff budgetStaff1;
        private Staff budgetStaff2;
        private Staff budgetStaff3;
        private Staff innovationStaff1;
        private Staff innovationStaff2;

        // new list for staff
        //List<Staff> staffs = new List<Staff>();



        public EmployeeController()
        {
            // create all in the constructor of EmployeeController.

            ceo = new CEO("Alice", "Doe", "CEO Department", "123456", 1000000, "CEO", "12345", "ceo@example.com");
            cfo = new CFO("John", "Smith", "CFO Department", "789012", 800000, "CFO", "54321", "cfo@example.com");
            coo = new COO("Bob", "Johnson", "COO Department", "654321", 800000, "COO", "98765", "coo@example.com");

            itChief = new DepartmentChief("Mike", "Wilson", "IT Department", "135792", 300000, "Chief", "45678", "it@example.com");
            financeChief = new DepartmentChief("Sophia", "Brown", "Finance Department", "876543", 300000, "Chief", "34567", "finance@example.com");


            itTestManager = new Manager("Chris", "Lee", "IT Department", "987654", 150000, "Test Manager", "34567");
            itProjectManager = new Manager("Emily", "Davis", "IT Department", "567890", 150000, "Project Manager", "23456");
            itDevManager = new Manager("Sarah", "Brown", "IT Department", "246813", 150000, "Development Manager", "87654");

            budgetManager = new Manager("Tom", "Johnson", "Finance Department", "543210", 120000, "Budget Manager", "98765");
            innovationManager = new Manager("Laura", "Smith", "Innovation Department", "432109", 120000, "Innovation Manager", "87654");

            hrStaff = new HRStaff("Grace", "Miller", "HR Department", "789123", 80000);
            
            itDevStaff1 = new Staff("Daniel", "Wilson", "It Development Department", "654321", 80000);
            itDevStaff2 = new Staff("Olivia", "Johnson", "It Development Department", "987654", 80000);
            itDevStaff3 = new Staff("Ethan", "Davis", "It Development Department", "987654", 80000);
            itTestStaff1 = new Staff("Ava", "Smith", "IT Test Department", "246810", 80000);
            itTestStaff2 = new Staff("Liam", "Jones", "IT Test Department", "135792", 80000);
            itTestStaff3 = new Staff("Mia", "Taylor", "IT Test Department", "345678", 80000);
            itProjectStaff1 = new Staff("Noah", "White", "IT Project Department", "876543", 80000);
            itProjectStaff2 = new Staff("Lily", "Wilson", "IT Project Department", "111222", 80000);
            itProjectStaff3 = new Staff("Lis", "Hansen", "HR Project Department", "987654", 80000);

        }
        public void Run()
        {
            // create an object of Display
            Display show = new Display();

            // Hr Staff add staff to Staff list:
            hrStaff.AddStaff(itDevStaff1);
            hrStaff.AddStaff(itDevStaff2);
            hrStaff.AddStaff(itDevStaff3);
            hrStaff.AddStaff(itTestStaff1);
            hrStaff.AddStaff(itTestStaff2);
            hrStaff.AddStaff(itTestStaff3);
            hrStaff.AddStaff(itProjectStaff1);
            hrStaff.AddStaff(itProjectStaff2);
            hrStaff.AddStaff(itProjectStaff3);

            // ceo add chiefs and managers
            ceo.AddChief(itChief);
            ceo.AddChief(financeChief);

            ceo.AddManager(itDevManager);
            ceo.AddManager(itTestManager);
            ceo.AddManager(itProjectManager);
            ceo.AddManager(budgetManager);
            ceo.AddManager(innovationManager);

            // ceo: Show all chiefs and managers 
            show.Print("====================CEO checks chief list:====================");
            show.Print(ceo.GetChiefList());
            show.Print("\n====================CEO checks manager list:====================");
            show.Print(ceo.GetManagerList());

            // manager: Show all staff 
            show.Print("====================It Development Manager checks staff list:====================");
            show.Print(itDevManager.GetStaffs());


            // hrStaff: Show all staffs
            show.Print("\n====================hrStaff checks staff list:====================");
            show.Print(hrStaff.GetStaffs());
            

        }

       
    }
}
