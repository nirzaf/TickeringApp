// See https://aka.ms/new-console-template for more information

using System.Management;
using TicketingApp;

namespace TickeringApp;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Your Name: ");
        var name = Console.ReadLine();

        Console.WriteLine("Enter Your Position: ");
        var position = Console.ReadLine();

        Console.WriteLine("Enter Your Salary: ");
        var salary = Convert.ToInt32(Console.ReadLine());

        var employee = new Employee(name, position, salary);

        Console.WriteLine($"Name: {employee.Name}, Position: {employee.Position}, Salary: {employee.Salary}");

        // Create a ManagementObjectSearcher to query the CPU usage
        var searcher = new ManagementObjectSearcher("select * from Win32_Processor");
        var cpuUsagePerformanceCounter = searcher.Get().Cast<ManagementObject>().First();

        // Get the CPU usage value
        var cpuUsage = Convert.ToSingle(cpuUsagePerformanceCounter["LoadPercentage"]);

        Console.WriteLine($"CPU Usage: {cpuUsage}%");
    }
}
