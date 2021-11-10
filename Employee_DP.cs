using System;

    class Employee_DP
    {
    public int id;
    string name;
    
    int salary;
    // public Employee()
    // {

    // }
    // public Employee(int id, string name,  
    //     int salary)
    // {
    //     this.id = id;
    //     this.name = name;
        
    //     this.salary = salary;

    // }

    public virtual void GetDetails()
    {
        Console.WriteLine("Enter ID");
        id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Name");
        name = Console.ReadLine();
        
        Console.WriteLine("Enter Salary");
        salary = int.Parse(Console.ReadLine());
    }
    public virtual void DisplayDetails()
    { 
        Console.WriteLine("ID is " + id);
        Console.WriteLine("Name is " + name);
        
        Console.WriteLine("Salary is " + salary);
    }
    }
