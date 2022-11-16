using static System.Console;
using static System.Math;
using System.Windows;
using System.Numerics;
using System.Diagnostics;


public partial class Program
{
    static void Main(string[] args)
    {
        var sw = new Stopwatch();

        int[] big = new int[10_000_000];
        Console.WriteLine("Initializing");
        sw.Start();
        var r = new Random(0);
        for (int i = 0; i < big.Length; i++)
        {
            big[i] = r.Next(big.Length);
        }
        sw.Stop();
        Console.WriteLine(sw.Elapsed.ToString("s\\.ff") + " seconds");
        Console.WriteLine();

        Console.WriteLine("Searching");
        double totalTime = 0;
        for (int i = 0; i < 1000; i++)
        {
            int searchFor = r.Next(big.Length);
            sw.Reset();
            sw.Start();
            int idx = Array.IndexOf(big, searchFor);
            sw.Stop();
            totalTime += sw.Elapsed.TotalSeconds;
            // WriteLine($"Index of {searchFor} is {idx}, time spent is {sw.Elapsed:s\\.ffff} seconds");

        }
        Console.WriteLine($"*** Total time spent searching is {totalTime} seconds");

        Console.WriteLine("Sorting");
        sw.Reset();
        sw.Start();
        Array.Sort(big);
        sw.Stop();
        Console.WriteLine($"Sorting took {sw.Elapsed:s\\.ff} seconds");
        Console.WriteLine();

        Console.WriteLine("Searching (binary)");
        totalTime = 0;
        for (int i = 0; i < 1000; i++)
        {
            int searchFor = r.Next(big.Length);
            sw.Reset();
            sw.Start();
            int idx = Array.BinarySearch(big, searchFor);
            sw.Stop();
            totalTime += sw.Elapsed.TotalSeconds;
            // WriteLine($"Index of {searchFor} is {idx}, time spent is {sw.Elapsed:s\\.ffffff} seconds");
        }
 Console.WriteLine($"*** Total time spent searching is {totalTime} seconds");

    }






}

