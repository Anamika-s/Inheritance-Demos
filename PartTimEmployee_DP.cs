using System;

    class PartTimEmployee_DP : Employee_DP
    {
     
    string projectName;
    int duartion;
    
   // Method Overriding
   //public void GetPartTimeDetails()
    public override void GetDetails()
    {   base.GetDetails();
        Console.WriteLine("Enter projectName");
        
        projectName = Console.ReadLine();
       
        Console.WriteLine("Enter duartion");
        duartion = int.Parse(Console.ReadLine());
    }
   // public void DisplayPartTimeDetails()
    public override void DisplayDetails()
    {   base.DisplayDetails();
        Console.WriteLine("projectName is " + projectName);
        Console.WriteLine("duartion is " + duartion);
        
    }
    }
