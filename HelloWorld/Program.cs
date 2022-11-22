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
        using(var r = new StreamReader("Program.cs"))
        {
            while(!r.EndOfStream)
            {
                Console.WriteLine(r.ReadLine());
                r.Dispose();
            }
        }


    }








}


