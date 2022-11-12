using static System.Console;
using static System.Math;
class Program
{
    static void Main(string[] args)
    {
        Counter c1 = new Counter();
        c1.GetNextValue();
        Counter c2 = c1;
        Counter c3 = new Counter();
        c3.GetNextValue();

        WriteLine(c1.Count);
        WriteLine(c2.Count);
        WriteLine(c3.Count);

        WriteLine(c1 == c2);
        WriteLine(c1 == c3); // false 
        WriteLine(c2 == c3);

        
        WriteLine(object.ReferenceEquals(c1, c2)); // true
        WriteLine(object.ReferenceEquals(c1, c3)); // false 
        WriteLine(object.ReferenceEquals(c2, c3));

        WriteLine("comparing ints");
        int i1 = new int();
        i1++;
        int i2 = i1;
        Int16 i3 = new int();
        i3++;

        WriteLine(i1);
        WriteLine(i2);
        WriteLine(i3);

        WriteLine(i1 == i2);
        WriteLine(i1 == i3);
        WriteLine(i2 == i3);

        
        WriteLine(Object.ReferenceEquals(i1, i2));
        WriteLine(object.ReferenceEquals(i1, i3)); 
        WriteLine(object.ReferenceEquals(i2, i3));
        WriteLine(object.ReferenceEquals(i3, i3));

       

        

    }
}

public class Counter
{
    private int _count;
    private static int _totalCount;

    public int GetNextValue()
    {
        this._count += 1;
        _totalCount += 1;
        return _count;
    }
    public int Count => _count;

    public static int TotalCount => _totalCount;

    public static int GetTotalCount()
    {
        return _totalCount;
    }

}