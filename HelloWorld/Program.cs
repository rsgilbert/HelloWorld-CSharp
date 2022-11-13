using static System.Console;
using static System.Math;
using System.Windows;

public  partial class Program
{
     static void Main(string[] args)
    {
        Bedroom b = new Bedroom();
        WriteLine(b.Chairs);
        WriteLine(b.Windows);
        WriteLine(Cry());
        WriteLine(b.Doors());

    }
    public static partial string Cry();

    public static partial string Cry()
    {
        return "I am crying";
    }
}

public partial class Bedroom
{
    public int Windows => 3;

    public partial int Doors();
}