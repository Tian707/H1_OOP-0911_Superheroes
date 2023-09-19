using H1_OOP_AccessModifier_TheFirm.Controller;

namespace H1_OOP_AccessModifier_TheFirm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeController ctrl = new EmployeeController(); 
            ctrl.GetEmployees();
        }
    }
}