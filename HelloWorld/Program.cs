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

        Predicate<int> g0 = GreaterThanZero;
        Predicate<int> megaPredicate1 = g0 + GreaterThanOne + GreaterThanTwo;
        megaPredicate1 = megaPredicate1 - GreaterThanTwo;
        WriteLine(megaPredicate1(2));

        Predicate<int> megaPred2 = g0;
        megaPred2 += GreaterThanTwo;
        megaPred2 += GreaterThanOne;
        WriteLine(megaPred2(2));


    }
    private static bool GreaterThanZero(int v)
    {
        WriteLine($"Executing {GreaterThanZero}");
        return v > 0;
    }
    private static bool GreaterThanOne(int v)
    {
        WriteLine($"Executing {GreaterThanOne}");
        return v > 1;
    }
    private static bool GreaterThanTwo(int v)
    {
        WriteLine($"Executing {GreaterThanTwo}");
        return v > 2;
    }



}
