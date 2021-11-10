using System;

namespace InheritanceDemo
{
    class Program_DP
    {
        static void Main(string[] args)
        {
            
Employee_DP employee = new   Employee_DP();
employee.GetDetails();
employee.DisplayDetails();

Console.WriteLine("Full Time Employee ");
Employee_DP fulltimeempoyee = new FullTimeEmployee_DP();
fulltimeempoyee.GetDetails();
fulltimeempoyee.DisplayDetails();
Employee_DP partTimEmployee = new Employee_DP();
partTimEmployee.GetDetails();
partTimEmployee.DisplayDetails();


        }
    }
}
