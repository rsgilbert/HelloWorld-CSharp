using static System.Console;
using static System.Math;
using System.Windows;
using System.Reflection;


public partial class Program
{
    static void Main(string[] args)
    {
        WriteLine(GetCopyrightForType(new List<int>()));
    }

    public static string GetCopyrightForType(object o)
    {
        Assembly asm = o.GetType().Assembly;
        var copyrightAttribute = (AssemblyCopyrightAttribute) asm.GetCustomAttributes(typeof (AssemblyCopyrightAttribute), true)[0];
        return copyrightAttribute.Copyright;
    }


}

public class Hey {}
