using static System.Console;
using static System.Math;
using System.Windows;
using System.Numerics;


public partial class Program
{
    static void Main(string[] args)
    {
        var weekdays = new[] { "Monday", "Thursday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        WriteLine(weekdays[0]);
        WriteLine(weekdays);

        var i = Array.LastIndexOf(weekdays, "Thursday");
        WriteLine($"i is {i}, element is {weekdays[i]}");

        var i2 = Array.FindIndex(weekdays, d => d == "Tuesday");
        WriteLine($"i2 is {i2}, element is {weekdays[i2]}");

        var sixLettered = Array.FindAll(weekdays, d => d.Length == 6);
        WriteLine($"Count is {sixLettered.Length}");
    }

 

}

