// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace TickeringApp;

internal static class Program
{
    static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<MyBenchmark>();
        Console.WriteLine(summary);         
    }
}

//     | Method               | Mean      | Error     | StdDev    | Median    |
//     |--------------------- |----------:|----------:|----------:|----------:|
//     | MeasureUsingContains |  4.020 ns | 0.1777 ns | 0.4983 ns |  3.990 ns |
//     | MeasureUsingAny      | 24.025 ns | 1.2563 ns | 3.5843 ns | 22.780 ns |


public class MyBenchmark
{
    private readonly List<int> _numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

    [Benchmark]
    public bool MeasureUsingContains() => _numbers.Contains(5);

    [Benchmark]
    public bool MeasureUsingAny() => _numbers.Any(x => x == 5);
}



// Console.WriteLine("Enter Your Name: ");
//
// var name = Console.ReadLine();
//
// Console.WriteLine("Enter Your Position: ");
//
// var position = Console.ReadLine();
//
// Console.WriteLine("Enter Your Salary: ");
//
// var salary = Convert.ToInt32(Console.ReadLine());
//
// var employee = new Employee(name, position, salary);
//
// Console.WriteLine($"Name: {employee.Name}, Position: {employee.Position}, Salary: {employee.Salary}");
//
// public class Employee(string name, string position, int salary)
// {
//     public string Name { get; set; } = name;
//     public string Position { get; set; } = position;
//     public float Salary { get; set; } = salary;
// }