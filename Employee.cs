namespace TicketingApp
{
    public class Employee(string name, string position, int salary)
    {
        public string Name { get; set; } = name;
        public string Position { get; set; } = position;
        public int Salary { get; set; } = salary;
    }
}
