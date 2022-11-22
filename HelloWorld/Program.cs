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
        ReadFiles();

    }

    static void ReadFiles()
    {
        foreach (string filename in Directory.EnumerateFiles("."))
        {
            Console.WriteLine(filename);
        }
    }

    static void CopyFiles(string fname1, string fname2)
    {
        using (Stream source = File.OpenRead(fname1))
        using (Stream destination = File.Create(fname2))
        {
            source.CopyTo(destination);
        }
    }

    static void ReadMoreCompact()
    {
        using StreamReader reader = File.OpenText(@"./HelloWorld.csproj");
        Console.WriteLine(reader.ReadToEnd());
    }

    static void ReadCompact()
    {
        using (StreamReader reader = File.OpenText(@"./HelloWorld.csproj"))
        {
            Console.WriteLine(reader.ReadToEnd());
        }
    }

    static void ReadVerbose()
    {
        StreamReader reader = File.OpenText(@"./HelloWorld.csproj");
        try
        {
            Console.WriteLine(reader.ReadToEnd());
        }
        finally
        {
            if (reader != null)
            {
                WriteLine("Disposing reader " + reader);
                reader.Dispose();
            }
            else
            {
                WriteLine("reader is null");
            }
        }
    }

}



public sealed class MyLogger : IDisposable
{
    private StreamWriter? _file;

    public MyLogger(string filePath)
    {
        _file = File.CreateText(filePath);
    }

    public void Dispose()
    {
        _file?.Dispose(); 
        _file = null;
    }
}