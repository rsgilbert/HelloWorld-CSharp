using System.Diagnostics;
using System.Numerics;
 

 // a declaration space is a region of code in which a single name must not refer to 
 // two different entities
 public class Counter 
 {
    private int _count;
    private static int _totalCount;

    public  int  GetNextValue()
    {
        string _count = "f";
        string _totalCount = "m";
        this._count += 1;
        Counter._totalCount = 1;
        return _count;
    }

    public static int TotalCount => _totalCount;

    public static int GetTotalCount()
    {
        return _totalCount;
    }

 }

class Program 
{
    static void Main(string[] args)
    {
        var c1 = new Counter();
        var c2 = new Counter();
        Console.WriteLine(c1.GetNextValue());
        Console.WriteLine(c1.GetNextValue());

        Console.WriteLine(c2.GetNextValue());

        Console.WriteLine($"total count {Counter.GetTotalCount()}");
    }
}