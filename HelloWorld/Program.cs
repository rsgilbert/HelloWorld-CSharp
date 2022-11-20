using static System.Console;
using static System.Math;
using System.Windows;
using System.Numerics;
using System.Diagnostics;
// using System.Collections;

public class Program
{
    static void Main(string[] args)
    {
        MyCls m = new MyCls();
        WriteLine(m);
    }






}


public sealed class MyCls
{
    public sealed override string ToString()
    {
        return "Yes yes";
    }
}