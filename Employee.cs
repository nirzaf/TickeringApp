namespace TicketingApp
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string position, int salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }
    }
}
