using System;
class FullTimeEmployee : Employee
{
  string manager;
  string department;
//public void GetFullTimeDetails()
public void GetDetails()
  {base.GetDetails();
      Console.WriteLine("Enter manager");
        
        manager = Console.ReadLine();
       
        Console.WriteLine("Enter department");
        department =  Console.ReadLine();
  }
   //public void DisplayFullTimeDetails()
    public void DisplayDetails()
    {   base.DisplayDetails();
        Console.WriteLine("manager is " + manager);
        Console.WriteLine("department is " + department);
        
    }
}