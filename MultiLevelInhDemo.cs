using  System;

class Student
{
  int rn;
  string name;
  public void GetDetails()
  {
    Console.WriteLine("Enter RollNo");
    rn = Byte.Parse(Console.ReadLine());
    Console.WriteLine("Enter Name");
    name = Console.ReadLine();
  }
  public void DisplayDetails()
  {
    Console.WriteLine("Roll No : " + rn);
    Console.WriteLine("Name : " + name);
  }
}

class Sports : Student
{
  string sportsName;
  protected int score;
 public void GetDetails()
  {base.GetDetails();
    Console.WriteLine("Enter sportsName");
    sportsName =  Console.ReadLine();
    Console.WriteLine("Enter score");
    score = Byte.Parse(Console.ReadLine());
  }
  public void DisplayDetails()
  {base.DisplayDetails();
    Console.WriteLine("sportsName : " + sportsName);
    Console.WriteLine("score : " + score);
  }

}

class Test : Sports 
{
 int [] marks = new int[3];
 protected int total=0;
  public void GetDetails()
  {base.GetDetails();
    Console.WriteLine("Enter Marks");
    for(int i=0;i<3;i++)
    {
    marks[i] =  Byte.Parse(Console.ReadLine());
    total+= marks[i];
    }
  }
  public void DisplayDetails()
  {base.DisplayDetails();
   
    Console.WriteLine("total : " + total);
     
  }
}
class Result : Test
{
  int score;
  public void CalculateScore()
  { base.GetDetails();
 score= total + score;
  }
  public void DisplayDetails()
  {base.DisplayDetails();
    Console.WriteLine("score : " + score);
     
  }
}