class Employee
{
  string firstname;
  string lastname;
  string id;
  int age;
  string address;
  string phonenumber;
  string title;
  double yearlysalary;
  string employmentstatus;

  

  public Employee()
  {
    firstname = "Unknown";
    lastname = "Unknown";
    id = "Unknown";
    age = 0;
    employmentstatus = "active";
  }

  
  public Employee(string firstname, string lastname, string id, int age)
  {
    firstname = "Unknown";
    lastname = "Unknown";
    id = "Unknown";
    age = 0;
  }

  public void Intro()
  {
    Console.WriteLine(firstname + " " + lastname + " (employee id: " + id + ") is " + age + " and is " + employmentstatus);
  }
}