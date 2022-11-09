using System.Diagnostics;
using System.Numerics;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            (int X, int Y) point = (1, 4);
            Console.WriteLine($"X is {point.X}, Y is {point.Y}");

            var sides = (right: 10, left: 5, top: 15, bottom: 4);
            Console.WriteLine(sides);
            Console.WriteLine($"Perimeter = {sides.right + sides.top + sides.bottom + sides.left}");

            string firstname = "John";
            string lastname = "Walker";

            var names = (firstname, lastname);
            Console.WriteLine(names);

            (int, int, string) info = (2, 123, "James");
            Console.WriteLine($"{info.Item1}, {info.Item2}, {info.Item3}");

            (int p2, int q2) point2 = point;
            Console.WriteLine(point2.q2);


            // deconstruction
            (double l, double w, double h) cube = (1, 2, 3);

            (double l2, double w2, double h2) = cube;

            Console.WriteLine(w2);
            double n, m, o;
            (n, m, o) = cube;
            Console.WriteLine(o);


        }

    }

}





