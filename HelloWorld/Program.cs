using static System.Console;
using static System.Math;
using System.Windows;

public partial class Program
{
    static void Main(string[] args)
    {
        var comparer = new GenericComparer<int>();
        int[] arr = {0, 1, 8, 3};

        Array.Sort(arr, comparer);
        WriteLine(string.Join(",", arr));
    }

}



public class GenericComparer<T> : IComparer<T> 
    where T : IComparable<T> 
{
    public int Compare(T? t1, T? t2) 
    {
        return t1?.CompareTo(t2) ?? -1;
    }
}

public class Foo<T1, T2> where T1 : T2 
{

}



