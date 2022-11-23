using static System.Console;
using static System.Math;
using System.Windows;
using System.Numerics;
using System.Diagnostics;
using System.Net.Http;



public class Program
{

    static void Main(string[] args)
    {
        try
        {
            WriteLine("Trying");
            int  n = 0;
            // int i = 4 / n;
            int k = Div(3, 0);
        }
        catch(DivideByZeroException x)
        {
            WriteLine(x.Message);
        }
        finally
        {
            WriteLine("Doing  a finally");
        }
        int Div(int n, int m) 
        {
            return n / m;
        }


    }








}


