using System.Diagnostics;
using System.Numerics;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name = "Jane";
            double age = 5.1981;
            // string interpolation 
            string msg = $"{name} is {age:f1} years old";
            Console.WriteLine(msg);

            string msg2 = string.Format("Again, {0} is {1} years old", name, age);
            Console.WriteLine(msg2);

            double pi = 3.1486;
            Console.WriteLine(pi.ToString("f2"));

            // verbatim string literals
            string p = @"C:\windows\assembly
            
        z";
            Console.WriteLine(p);
        }

    }
    
}





