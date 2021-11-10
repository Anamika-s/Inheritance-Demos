using System;
class FullTimeEmployeeWithConstructor : EmployeeWithConstuctor
{
  string manager;
  string department;
  // Add def cons to the child class
  public FullTimeEmployeeWithConstructor () : base () {}
  public FullTimeEmployeeWithConstructor(
    int id, string name, int salary , 
    string manager , string department )
  : base (id, name, salary)
  {
    this.manager = manager;
    this.department = department;
  }
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