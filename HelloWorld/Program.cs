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
            throw new AggregateException();
           // int i = 4 / n;

        }
        catch(DivideByZeroException x)
        {
            WriteLine(x.Message);
            throw; 
        }
        finally
        {
            WriteLine("Doing  a finally");
        }
    
        WriteLine(CountCommas("hey there, madam, how are you?"));
        WriteLine(CountCommas(null));

   

    }

    public static int CountCommas(string? text)
    {
        if(text ==null)
        {
            throw new ArgumentNullException(nameof(text));
        }
        return text.Count(c => c == ',');
    }



}




