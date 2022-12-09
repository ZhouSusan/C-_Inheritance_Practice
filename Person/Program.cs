using Person;

//Employee 
Employee emp = new Employee();
emp.FirstName = "James";
emp.LastName = "Bass";
emp.EmployeeId = 1;
emp.CompanyName = "Guitar Band";

var fullName = emp.GetFullName();
Console.WriteLine(fullName);

//Student
Student stud = new Student();
stud.FirstName = "Addriane";
stud.LastName = "Kays";
stud.StudentId = 9003;
stud.SchoolName = "Unversity Of Washingtion";
Console.WriteLine(stud.GetFullName());