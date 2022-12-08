using Person;

Employee emp = new Employee();
emp.FirstName = "James";
emp.LastName = "Bass";
emp.EmployeeId = 1;
emp.CompanyName = "Guitar Band";

var fullName = emp.GetFullName();
Console.WriteLine(fullName);