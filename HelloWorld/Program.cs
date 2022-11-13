using static System.Console;
using static System.Math;
using System.Windows;

public class Program
{
    static void Main(string[] args)
    {
        var x = new { Title = "Lord", Surname = "Voldemort"};
        var y = new { Title = "Lord", Surname = "Voldemort"};
        WriteLine($"Welcome, {x.Title} {x.Surname}");
        WriteLine(x == y); // false

    }



}