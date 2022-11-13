using static System.Console;
using static System.Math;
using System.Windows;

public class Program
{
    static void Main(string[] args)
    {
        var c1 = new Counter { Count = 3 };
        var c2 = new Counter { Count = 7 };
        var cSum = c1 + c2;
        WriteLine($"Count sum {cSum.Count}");
        var c3 = 5 + c1;
        WriteLine($"sum {c3.Count}");
        c2 += 1;
        WriteLine($"c2 {c2.Count}");
        c2++;
        WriteLine($"c2 {c2.Count}");
        int i = (int)c2;
        WriteLine(i);
        double d = c3;
        WriteLine(d);

        // c3.Count = -5;
        if ((bool)c3)
        {
            Console.WriteLine($"c3 {(int)c3} is true");
        }

    }

}

class Counter
{
    public int Count { get; set; } = 0;
    public static Counter operator +(Counter x, Counter y)
    {
        return new Counter { Count = x.Count + y.Count };
    }
    public static Counter operator +(int i, Counter c)
    {
        return new Counter { Count = i + c.Count };
    }
    public static Counter operator +(Counter c, int i)
    {
        return i + c;
    }
    public static Counter operator ++(Counter c)
    {
        return c + 1;
    }

    public static explicit operator int(Counter c)
    {
        return c.Count;
    }
    public static implicit operator double(Counter c)
    {
        return c.Count;
    }

    public static explicit operator bool(Counter c)
    {
        return c.Count > 0;
    }
}
