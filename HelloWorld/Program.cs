using static System.Console;
using static System.Math;
using System.Windows;
using System.Numerics;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.Serialization;

public class Program
{

    static void Main(string[] args)
    {
        int[] bins = { 0, -5, -1, 50, 2, 4 };
        bool IsGreaterThanZero(int value) => value > 0;

        int firstGreater = Array.FindIndex(bins, Works.AlwaysFalse);
        WriteLine(firstGreater);

        // We are refering to IsGreaterThanZero by name, the name IsGreaterThanZero is in this case a method case 
        // since there maybe many methods called IsGreaterThanZero but taking different parameters
        Predicate<int> p = IsGreaterThanZero;// new Predicate<int>(IsGreaterThanZero);
        WriteLine(p(10));
        var m = p(3);


    
    }




}


class Works
{
    public static bool AlwaysFalse(int k) => false;
}