using System;
class FullTimeEmployee_DP : Employee_DP
{
  string manager;
  string department;
//public void GetFullTimeDetails()
public override void GetDetails()
  {   base.GetDetails();
      Console.WriteLine("Enter manager");
        
        manager = Console.ReadLine();
       
        Console.WriteLine("Enter department");
        department =  Console.ReadLine();
  }
   //public void DisplayFullTimeDetails()
    public override void DisplayDetails()
    {    base.DisplayDetails();
        Console.WriteLine("manager is " + manager);
        Console.WriteLine("department is " + department);
        
    }
}