using System;

class Faculty : Person 
{
  public string Id { get; set; }

  public string Title { get; set; }

  public DateTime DateOfEmployment { get; set; }

  public string Employer { get; set; }

  public decimal YearlySalary { get; set; }

  public bool Tenured { get; set; } 

  public Faculty() : base()
  {
    Title = "Instructor";
  }

  public Faculty(string fnamne, string lname) : base(fnamne, lname)
  {
    Title = "Instructor";
  }

  public bool GrantTenure() 
  {
    int tenurecheck = DateOfEmployment.Year;
    if (tenurecheck + 5 < DateTime.Today.Year)
      return true;
    else
      return false; 
  }

  public bool Promote()
  {
    double length = DateTime.Today.Year - DateOfEmployment.Year;   

    if ((length >= 2) && (length < 5) && (Title == "Instructor"))
     {
      Title = "Assistant Professor";
      Console.WriteLine("Faculty promoted to Assistant Professor rank");
      return true; 
      }
    else if ((length >= 5) && (length < 10) && (Title == "Assistant Professor"))
     {
      Title = "Associate Professor";
      Console.WriteLine("Faculty promoted to Associate Professor rank");
      return true;
      }
    else if ((length >= 10) && (Title == "Associate Professor"))
     {
      Title = "Professor";
      Console.WriteLine("Faculty promoted to Professor Rank");
      return true;
      }
    else if (Title == "Professor")
     {
        Console.WriteLine("No more promotion is possible");
        return true;
     } else {
       return false;
     }
     
  }

  public override void Intro()
  {
    Console.WriteLine("I have worked as " + Title + " at " + Employer + " since " + DateOfEmployment.Year);
  }

}
