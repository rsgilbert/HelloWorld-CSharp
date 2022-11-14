using static System.Console;
using static System.Math;
using System.Windows;
// using Microsoft.VisualBasic.T

public partial class Program
{
    static void Main(string[] args)
    {
        Bar<IAge> b = new Bar<IAge>();
    }

}


public class Bar<T> where T : class
{

}

public interface IAge {}
public class Age { }




