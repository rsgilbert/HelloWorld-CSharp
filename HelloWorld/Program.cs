using static System.Console;
using static System.Math;
using System.Windows;
using System.Numerics;
using System.Diagnostics;
// using System.Collections;

public class Program
{
    static void Main(string[] args)
    {
        Rectangle  r1 = new Rectangle()
        {
            Width = 5,
            Height = 10
        };
        RoundedRectangle r2 = new RoundedRectangle()
        {
            Width = 3,
            Height = 4
        };
        var arr1 = new[] { r1, r2 };
        Array.Sort(arr1, new BoxAreaComparer());
        foreach(var r in arr1)
        {
            WriteLine($"{r.Width}x{r.Height}");
        }
    }

   
 



}


public class Rectangle 
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double Area => Width * Height;
}

public class RoundedRectangle : Rectangle 
{
    public double CornerRadius { get; set; }
}


public class BoxAreaComparer : IComparer<Rectangle>
{
    public int Compare(Rectangle? r1, Rectangle? r2)
    {
        return Math.Sign(r1?.Area ?? 0 - r2?.Area ?? 0);
    }
}


public class CornerSharpnessComparer : IComparer<RoundedRectangle>
{
    public int Compare(RoundedRectangle? r1, RoundedRectangle? r2)
    {
        // smaller corners are sharper
        return Math.Sign(-1 * ((r1?.CornerRadius ?? 0) - (r2?.CornerRadius ?? 0)));
    }
}



