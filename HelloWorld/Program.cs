using System.Diagnostics;
using System.Numerics;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            object o = (3, 3);
            
            switch(o)
            {
                case string :
                    Console.WriteLine($"string is {o}");
                    break;
                case int i:
                    Console.WriteLine($"integer is {i}");
                    break;
                case double d:
                    Console.WriteLine($"double {d}");
                    break;
                case (3, int y):
                    Console.WriteLine($"x is {3}, y is {y}");
                    break;
                case (int n, int m, int r):
                break;
            }

            string msg = "Hey t";

            switch(msg)
            {
                case { Length: 0}:
                    Console.WriteLine("Blank");
                    break;
                case { Length: 3}:
                    Console.WriteLine($"Length is 3");
                    break;
                case { Length: int l } when l >= 4 && l <= 6:
                    Console.WriteLine($"Short length {l}");
                    break;
                case { Length: int l }:
                    Console.WriteLine($"Length is really {l}");
                    break;
            }


            string shape = "Kiter";
            string layout = shape switch 
            {
                string s when s.Length == 4 => "Potrait",
                string s when s == "Kite" => "Square",
                _ => "Landscape"
            };
            Console.WriteLine(layout);

            // pattern in an is expression
            bool isString = "Hello" is string;
            Console.WriteLine(isString);
            
        }

    }

}





