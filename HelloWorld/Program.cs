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
        IBase1 b1 = new Base1Impl(); 
        // UseBase1(b1);
        ISpecialBase1 s1 = new SpecialBase1Impl();
        // UseBase1(s1);
        IEnumerable<ISpecialBase1> bases = new[] { s1, s1 };
        // WriteLine("** all bases");
        // AllBases(bases);

        ICollection<ISpecialBase1> specials = new List<ISpecialBase1>();
        // AddBase(specials);


        IRunner<IBase1> r1 = new Runner<IBase1>(b1);
        PrintCurrentRunner(r1);

        IRunner<ISpecialBase1> sr1 = new Runner<ISpecialBase1>(s1);
        PrintCurrentRunner(sr1);

    }

    public static void PrintCurrentRunner(IRunner<IBase1> r)
    {
        WriteLine(r.Current);
    }
    static void UseBase1(IBase1 b)
    {
        b.Base1Log();
    }

    public static void AllBases(IEnumerable<IBase1> bases)
    {
        foreach (IBase1 b in bases)
        {
            b.Base1Log();
        }
    }

    public static void AddBase(ICollection<IBase1> bases)
    {
        bases.Add(new Base1Impl());
    }



}

public class SpecialBase1Impl : ISpecialBase1
{
    public void Base1Log()
    {
        WriteLine("special impl of base1log");
    }
}
public class Base1Impl : IBase1
{
    public void Base1Log()
    {
        WriteLine("base1 impl of base1log");
    }

}

interface ISpecialBase1 : IBase1
{
}

public interface IBase1
{
    void Base1Log();
}



public interface IRunner<out T>
{
    T Current { get; }

   

}

public class Runner<T> : IRunner<T>
{
    private T _current;
    public Runner(T t)
    {
        _current = t;
    }
    public T Current => _current;
}
