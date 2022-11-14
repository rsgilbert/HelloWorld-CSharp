using static System.Console;
using static System.Math;
using System.Windows;
// using Microsoft.VisualBasic.T

public partial class Program
{
    static void Main(string[] args)
    {
        ValueTuple<int, int> p0 = (1, 4);
        var t = (1,2,3,4,5,6,7,8,9,10,11,12);
        WriteLine(t);

        var p1 = Pos();
     

    }

    public static (int X, int Y) Pos() => (5, 3);


}


public class TestC<T>
{
    public TestC(T t)
    { }
}