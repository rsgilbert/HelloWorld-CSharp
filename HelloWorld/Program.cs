using static System.Console;
using static System.Math;
using System.Windows;
using System.Numerics;
using System.Diagnostics;
// using System.Collections;

public partial class Program
{
    static void Main(string[] args)
    {
        var enumerable = CountDown(7, 5);
        var enumerator = enumerable.GetEnumerator();
        while(enumerator.MoveNext())
        {
            WriteLine(enumerator.Current);
        }

        foreach(int i in ThreeNumbers())
        {
            WriteLine(i);
        }
        enumerator =  CountDown2(3, 1);
        while(enumerator.MoveNext())
        {
            WriteLine(enumerator.Current);
        }

    }

    public static IEnumerable<int> CountDown(int start, int end)
    {
        for(int i = start; i >= end; i--)
        {
            yield return i;
        }
    }


    public static IEnumerator<int> CountDown2(int start, int end)
    {
        for(int i = start; i >= end; i--)
        {
            yield return i;
        }
    }

    public static IEnumerable<int> ThreeNumbers()
    {
        yield return 1;
        yield return 2;
        yield return 3;
    }


}


