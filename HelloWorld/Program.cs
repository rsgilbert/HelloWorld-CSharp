using static System.Console;
using static System.Math;
using System.Windows;
// using Microsoft.VisualBasic.T

public partial class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Peter", "Isaac", "Rodney" };
        WriteLine($"Last name is {GetLast(names)}");

        int[] ages = { 5, 3, 2 };
        WriteLine($"Last age is {GetLast(ages)}");



    }

    public static T GetLast<T>(T[] items) => items[items.Length - 1];

  



}


public class TestC<T>
{
    public TestC(T t)
    { }
}