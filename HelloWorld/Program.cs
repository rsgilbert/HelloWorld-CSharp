using static System.Console;
using static System.Math;
using MyApp;





class Program
{
    static void Main(string[] args)
    {
        string nm = "Jackie Chan";
        nm.PrintToConsole();
        "Magnus".PrintLength();
    }



}

namespace MyApp
{
    public static class MyStringExt 
    {
        public static void PrintToConsole(this string s) 
        {
            Console.WriteLine(s);
        }
        public static void PrintLength(this string s)
        {
            Console.WriteLine($"The length of {s} is {s.Length}");
        }
        
    }
}