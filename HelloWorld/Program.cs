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
            using (var r = new StreamReader("Abacus.cs"))
            {
                while (!r.EndOfStream)
                {
                    Console.WriteLine(r.ReadLine());
                    r.Dispose();
                }
            }
        }
        
        catch(FileNotFoundException x)
        when(x.FileName?.Contains("Program.css") == true)
        {
            WriteLine($"File {x.FileName} is missing");
            WriteLine(x.TargetSite);
        }
        catch(FileNotFoundException x)
        when(x.FileName?.Contains("Abacus.cs") == true)
        {
            WriteLine("Abacus is a bad file name");
        }
   
        catch(DirectoryNotFoundException x)
        {
            WriteLine($"Directory not found. {x.Message}");
        }

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


