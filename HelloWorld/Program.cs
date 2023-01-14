

using System;
using System.Reflection;

namespace System 
{
    public class String 
    {}
}

class Program 
{
    static void Main(string[] args)
    {
        var s1 = "jonathan";
        var s2 = "john";
        var s3 = "JOHN";
        var s4 = "JONATHAN";
        List<string> names = new string[] {s4, s1, s2, s3, }.ToList();
        names.Sort(GetComparer(true));
        foreach(string n in names)
        {
            Console.WriteLine(n);
        }

        // var a = Assembly.Load("System");
        var a = typeof(System.String);
        Console.WriteLine($"{a.FullName},, {a.Assembly.ToString()}");
    }

    public static IComparer<string> GetComparer(bool ignoreCase) 
    {
        if(ignoreCase)
        {
            return StringComparer.CurrentCultureIgnoreCase;
        }
        else 
        {
            return StringComparer.CurrentCulture;
        }
    }

    public static void ShowStaticTypeNameAndAssembly<T>(T item)
    {
        Type t = typeof(T);
        Console.WriteLine($"Type: {t.FullName}, Assembly: {t.Assembly.FullName}");
    }
}