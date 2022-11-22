using static System.Console;
using static System.Math;
using System.Windows;
using System.Numerics;
using System.Diagnostics;
// using System.Collections;
using System.Net.Http;

public class Program
{

    static void Main(string[] args)
    {
        try
        {
            using (var r = new StreamReader("/a/Program.css"))
            {
                while (!r.EndOfStream)
                {
                    Console.WriteLine(r.ReadLine());
                    r.Dispose();
                }
            }
        }
        
        catch(FileNotFoundException x)
        {
            WriteLine($"File {x.FileName} is missing");
            WriteLine(x.InnerException);
            // WriteLine(x.Message);
            // WriteLine(x.StackTrace);
            // WriteLine(x.ToString());
            WriteLine(x.TargetSite);
        }
   
        catch(DirectoryNotFoundException x)
        {
            WriteLine($"Directory not found. {x.Message}");
        }
        catch(IOException x)
        {}

        try
        {
            WriteLine(Divide(0, 0));
        }
        catch (DivideByZeroException x)
        {
            foreach (var p in x.Data)
            {
                WriteLine(p);
            }
            WriteLine("Could not divide by zero");
        }

        double Divide(int x, int y)
        {
            return x / y;
        }


    }








}


