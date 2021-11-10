using System;

    class Employee
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

    public void GetDetails()
    {
        Console.WriteLine("Enter ID");
        id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Name");
        name = Console.ReadLine();
        
        Console.WriteLine("Enter Salary");
        salary = int.Parse(Console.ReadLine());
    }
    public void DisplayDetails()
    { 
        Console.WriteLine("ID is " + id);
        Console.WriteLine("Name is " + name);
        
        Console.WriteLine("Salary is " + salary);
    }
    }
