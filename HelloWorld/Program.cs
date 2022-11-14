using static System.Console;
using static System.Math;
using System.Windows;
// using Microsoft.VisualBasic.T

public partial class Program
{
    static void Main(string[] args)
    {
       PrintDefault<string> pd = new PrintDefault<string>();
       PrintDefault<int> pi = new PrintDefault<int>();
       PrintDefault<long> pl = new PrintDefault<long>();
       PrintDefault<bool> pb = new PrintDefault<bool>();

       ShowDef<bool>();

       Print(default);

    }

    static T? ShowDef<T>() 
    {
        Console.WriteLine($"Default for is {default(T)}");
        return default;
    }
    static void Print(bool i)
    {
        Console.WriteLine($"i is {i}");
    }


   

}

public class PrintDefault<T> 
{
    public PrintDefault()
    {
        var d = default(T);
        Console.WriteLine(d);
    }
}

