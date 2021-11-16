using System;

class Faculty
{
  public string Id { get; set; }
  public string Title { get; set; }
  public string DateTime
  {
    get { return DateTime;}
    set { DateTime = value; }
  }
  public string Employer { get; set; }
  public double YearlySalary { get; set; }
  public bool Tenured { get; set; }

  public Faculty()
  {
    Title = "Instructor";
  }

  public string firstname;
  public string lastname;
  public Faculty(string FirstName, string LastName)
  {
    firstname = FirstName;
    lastname = LastName;
    Title = "Instructor";
  }

  public void GrantTenure()
  {
    Console.WriteLine("Number of Years Worked");
    int workyears = Convert.ToInt32(Console.ReadLine());
    if (workyears >= 5)
    {
      Tenured = true;
    }
    else
    {
      Tenured = false;
    }
  }

  public void Promote()
  {
    bool Instructor = false;
    bool AssistantProfessor = false;
    bool AssociateProfessor = false;
    bool Professor = false;
    bool title = true;
    if (title == Instructor)
    {
      Title = "Assistant Professor";
      Console.WriteLine("Promoted to Assistant Professor");
    }
    if (title == AssistantProfessor)
    {
      Title = "Associate Professor";
      Console.WriteLine("Promoted to Associate Professor");
    }
    if (title == AssociateProfessor)
    {
      Title = "Professor";
      Console.WriteLine("Promoted to Professor");
    }
    if (title == Professor)
    {
      Console.WriteLine("No promotion available");
    }
  }
}