using static System.Console;
using static System.Math;





class Program
{
    static void Main(string[] args)
    {
        Size s1 = new Size(5, 3);
        Size s2 = new Size(2, 0);
        WriteLine(Size.DiagonalLength(s1));
        WriteLine(Size.DescribeSize(s2));
    }



}

public readonly struct Size
{
    public Size(double w, double h)
    {
        W = w;
        H = h;
    }

    public void Deconstruct(out double w, out double h)
    {
        w = W;
        h = H;
    }

    public static double DiagonalLength(Size s)
    {
        (double width, double height) = s;
        return Math.Sqrt(width * width + height * height);
    }

    public static string DescribeSize(Size s) => s switch 
    {
        (0, 0) => "Empty",
        (0, _) => "Very narrow",
        (_, 0) => "Very short",
        _ => "Normal"
    };

    public double W { get; }
    public double H { get; }
}
