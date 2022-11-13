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

   
        int q = Divide(3, 4, out  int r);
        WriteLine($"Remainder {r}, Quotient {q}");

   
        int q2 = Divide(10, 3, out _);
        WriteLine($"q2 {q2}");

        decimal v = decimal.TryParse("12.198", out decimal result) ? result : -1;
        WriteLine($"Parsed value is {v}");

        long x = 31;
        Interlocked.Increment(ref x);
        WriteLine($"X {x}");

        int z = 4;
        Reduce(3, ref z);
        WriteLine($"z is {z}");
        
        double dd = 12;
        WriteLine($"Squared {Square(in dd)}, dd is still {dd}");
    }

    public static double Square(in double d)
    {
        var result = d * d;
        return result;
    }

    public static void Reduce(int byAmount, ref int n)
    {
        n = n - byAmount;
    }

    public static int Divide(int x, int y, out int remainder)
    {
        remainder = x % y;
        return x / y;
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
