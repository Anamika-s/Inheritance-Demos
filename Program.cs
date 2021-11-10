using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.GetDetails();
            employee.DisplayDetails();
   Console.WriteLine("Part Time Employee");
   PartTimEmployee partTimEmployee =  new PartTimEmployee();
   partTimEmployee.GetDetails();
   //partTimEmployee.GetPartTimeDetails();
   partTimEmployee.DisplayDetails();
   //partTimEmployee.DisplayPartTimeDetails();
   partTimEmployee.id = 100;
   Console.WriteLine("ID is " + partTimEmployee.id);

Console.WriteLine("Full Time Employee");
 FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
 fullTimeEmployee.GetDetails();
 //fullTimeEmployee.GetFullTimeDetails();
 fullTimeEmployee.DisplayDetails();
 //fullTimeEmployee.DisplayFullTimeDetails();

        }
    }
}
