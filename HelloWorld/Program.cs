using static System.Console;
using static System.Math;
using System.Windows;
// using Microsoft.VisualBasic.T

public partial class Program
{
    static void Main(string[] args)
    {
        RequireEnum<Size> r = new RequireEnum<Size>();

    }

    private enum Size { small, large }

}

public class RequireEnum<T>  where T : Enum 
{

}

