using System;

    class PartTimEmployeeWithConstructor : EmployeeWithConstuctor
    {
     
    string projectName;
    int duartion;
    // Constructors in Child Class
    public PartTimEmployeeWithConstructor() : base () {}
    public PartTimEmployeeWithConstructor(int id,
    string name,
    int salary,
    string projectName,
    int duartion) 
    : base (id, name, salary)
    {
        this.projectName = projectName;
        this.duartion = duartion;
    }
   // Method Overriding
   //public void GetPartTimeDetails()
    public void GetDetails()
    {   base.GetDetails();
        Console.WriteLine("Enter projectName");
        
        projectName = Console.ReadLine();
       
        Console.WriteLine("Enter duartion");
        duartion = int.Parse(Console.ReadLine());
    }
   // public void DisplayPartTimeDetails()
    public void DisplayDetails()
    {   base.DisplayDetails();
        Console.WriteLine("projectName is " + projectName);
        Console.WriteLine("duartion is " + duartion);
        
    }
    }
