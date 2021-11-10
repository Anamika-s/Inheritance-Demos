using System;

    class PartTimEmployee : Employee
    {
     
    string projectName;
    int duartion;
    
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
