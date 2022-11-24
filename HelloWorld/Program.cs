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
        void printSumOfTwo(int a1, int a2)
        {
            WriteLine(a1+a2);
        }
        performBinaryAction(printSumOfTwo, 100, 20);

        int TotalStringLength(string s1, string s2, string s3)
        {
            return s1.Length + s2.Length + s3.Length;
        }
        doAndPrintResult(TotalStringLength, "Jag", "cups", "tennis"); // 13
    }

    static void performBinaryAction(Action<int,int> action, int p1, int p2)
    {
        action(p1, p2);
    }

    static void doAndPrintResult(Func<string, string, string, int> func, string s1, string s2, string s3)
    {
        WriteLine(func(s1,s2,s3));
    }

    



}

public delegate bool NoArgCallback();
