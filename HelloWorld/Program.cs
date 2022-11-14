using static System.Console;
using static System.Math;
using System.Windows;
// using Microsoft.VisualBasic.T

public partial class Program
{
    static void Main(string[] args)
    {
        // below will be allowed if not for value type constraint
        // Bar<int?> b = new Bar<int?>(null);

        // below is allowed 
        Bar<int> b = new Bar<int>(4);

    }

}


public class Bar<T> where T : struct
{
    public Bar(T t)
    {
        t = default(T);
    }

}

public interface IAge {}
public class Age { }




