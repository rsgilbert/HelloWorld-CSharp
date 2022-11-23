using static System.Console;
using static System.Math;
using System.Windows;
using System.Numerics;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.Serialization;

public class Program
{

    static void Main(string[] args)
    {
        AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;


        throw new InvalidCastException("Why cast badly??");



        WriteLine("Hey");



    }

    private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        WriteLine($"An exception went unhandled: ${e.ExceptionObject}");
    }




}
