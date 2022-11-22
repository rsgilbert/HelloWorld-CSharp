using static System.Console;
using static System.Math;
using System.Windows;
using System.Numerics;
using System.Diagnostics;
// using System.Collections;
using System.Net.Http;

public class Program
{

    static void Main(string[] args)
    {
        int n = 5;
        Show(n);
        Show(new Box<int>(10));

    }

    static void Show(object o)
    {
        Console.WriteLine(o.ToString());
        WriteLine(o.GetType());
        if(o is int i)
        {
            WriteLine(i * 3);
        }
    }

    

    
    
}

public class Box<T> 
    where T : struct
{
    public readonly T Value;

    public Box(T value)
    {
        Value = value;
    }
    public override string ToString() => Value.ToString() ?? "";

    // wont work cuz GetType is not virtual
    public new Type GetType() => Value.GetType();   
}






