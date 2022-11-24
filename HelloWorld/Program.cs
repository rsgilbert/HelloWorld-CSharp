using static System.Console;
using static System.Math;
using System.Windows;
using System.Numerics;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Reflection;

public class Program
{

    static void Main(string[] args)
    {

        var w0 = new Works(0);
        Predicate<int> p0 = w0.Working;
        WriteLine(p0(1));
        WriteLine(p0(-5));
        w0.Count = 5;
        WriteLine(p0(1));

        var w1 = new Works(1);
        Predicate<int> p1 = w1.Working;
        WriteLine(p1(1));

// creating delegate using reflection
        MethodInfo? m1 = typeof(Works).GetMethod("Working");
        Predicate<int> p2 = (Predicate<int>) m1.CreateDelegate(typeof(Predicate<int>), w1);
        WriteLine(p2(11));




    }




}


class Works
{
    public int Count { get; set; }
    public static bool AlwaysFalse(int k) => false;

    public Works(int count)
    {
        Count = count;
    }

    public bool Working(int comp)
    {
        return comp > Count;
    }
}