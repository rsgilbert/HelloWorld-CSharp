using static System.Console;
using static System.Math;
using System.Windows;
using System.Numerics;
using System.Diagnostics;


public partial class Program
{
    static void Main(string[] args)
    {
        var a1 = new[] {1, 2,3};
        var a2 = new int[10];

        Array.Copy(a1, a2, 2);

        WriteLine(a2[1]);

        Array.Copy(a1, 0, a1, 2, 1);

        WriteLine(a1[2]);

        Array.Clear(a1);
        

        WriteLine(a1[2]);

        WriteLine(a1.Length);
        Array.Resize(ref a1, 15);
        WriteLine(a1.Length);

    }






}

