// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter Your Name: ");

var name = Console.ReadLine();

Console.WriteLine("Enter Your Position: ");

var position = Console.ReadLine();

Console.WriteLine("Enter Your Salary: ");

var salary = Convert.ToInt32(Console.ReadLine());

var employee = new Employee(name, position, salary);

Console.WriteLine($"Name: {employee.Name}, Position: {employee.Position}, Salary: {employee.Salary}");

public class Employee(string name, string position, int salary)
{
    public string Name { get; set; } = name;
    public string Position { get; set; } = position;
    public float Salary { get; set; } = salary;
}