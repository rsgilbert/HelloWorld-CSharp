using static System.Console;
using static System.Math;





class Program
{
    static void Main(string[] args)
    {
        var p1 = new Point(40, 2);
        Point p2 = p1;
        var p3 = new Point(40, 2);

        Console.WriteLine($"{p1.X}, {p1.Y}");
        Console.WriteLine($"{p2.X}, {p2.Y}");
        Console.WriteLine($"{p3.X}, {p3.Y}");

        WriteLine(p1 == p2);
        WriteLine(p2 == p3);
        WriteLine(object.Equals(p3, p2));
        
        var p5 = new Point2(8, 5);
        var p6 = new Point2(8, 5);
        
        
        Console.WriteLine($"{p5.X}, {p5.Y}");
        Console.WriteLine($"{p6.X}, {p6.Y}");
        WriteLine(p5 == p6);
        // WriteLine(object.ReferenceEquals(p1, p2));
    }

}

public readonly struct Point2 
{
    public Point2(double x, double y)
    {
        X = x;
        Y = y;
    }
    public double X { get; }
    public double Y { get; }

    public double DistanceFromOrigin()
    {
        return Math.Sqrt(X * X + Y * Y);
    }
    public static bool operator ==(Point2 p1, Point2 p2)
    {
        return p1.X == p2.X && p1.Y == p2.Y;
    }
    public static bool operator !=(Point2 p1, Point2 p2)
    {
        return !(p1 == p2);
    }
     public override bool Equals(object? o)
    {
        return o is Point2 p2 && this == p2;
    }
    public override int GetHashCode()
    {
        return (X, Y).GetHashCode();
    }
}


public struct Point 
{
    private double _x;
    private double _y;

    public Point(double x, double y)
    {
        _x = x;
        _y = y;
    }
    public double X => _x;
    public double Y => _y;

    public static bool operator ==(Point p1, Point p2)
    {
        return p1.X == p2.X && p1.Y == p2.Y;
    }
    public static bool operator !=(Point p1, Point p2)
    {
        return !(p1 == p2);
    }

    public override bool Equals(object? o)
    {
        return o is Point p2 && this == p2;
    }
    public override int GetHashCode()
    {
        return (X, Y).GetHashCode();
    }
}



