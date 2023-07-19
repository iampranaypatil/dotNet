using Testing;
using HR;


Department department = new Department();
Console.WriteLine("Enter Employee Id: ");
department.Id = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Employee Name: ");
department.Name = Console.ReadLine();

Console.WriteLine("Enter Employee location: ");
department.Location = Console.ReadLine();

bool insert = DbTestManager.Insert(department);
if (insert)
    Console.WriteLine("Data Inserted");
else
    Console.WriteLine("Data not Inserted");

List<Department> departments=DbTestManager.GetAllDepartments();
foreach ( Department dept in departments){
    Console.WriteLine(dept.Name + "  " + dept.Location);
}

//Database Operations unit Testing

