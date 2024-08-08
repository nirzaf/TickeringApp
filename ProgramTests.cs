using System.Management;
using TicketingApp;
using Xunit;

namespace TickeringApp
{
    public class ProgramTests
    {
        [Fact]
        public void TestEmployeeCreation()
        {
            var employee = new Employee("John Doe", "Developer", 60000);
            Assert.Equal("John Doe", employee.Name);
            Assert.Equal("Developer", employee.Position);
            Assert.Equal(60000, employee.Salary);
        }

        [Fact]
        public void TestCpuUsageMeasurement()
        {
            // Create a ManagementObjectSearcher to query the CPU usage
            var searcher = new ManagementObjectSearcher("select * from Win32_Processor");
            var cpuUsagePerformanceCounter = searcher.Get().Cast<ManagementObject>().First();

            // Get the CPU usage value
            var cpuUsage = Convert.ToSingle(cpuUsagePerformanceCounter["LoadPercentage"]);

            Assert.InRange(cpuUsage, 0, 100);
        }
    }
}
