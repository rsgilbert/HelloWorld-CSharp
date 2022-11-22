using static System.Console;
using static System.Math;
using System.Windows;
using System.Numerics;
using System.Diagnostics;
// using System.Collections;
using System.Net.Http;

public class Program
{

    static void Main(string[] args)
    {
        // special unboxing of Nullable<T>
          object b = null;
        int? n = b as int?;
        int? n2 = (int?) b;
        WriteLine(n);
        WriteLine(n2);
        // int n3 = (int)b;
        // WriteLine(n3);

        // var b = new Box<int?>(null);
        // int n = b as int;
        // int n3 = b.Value;
        // WriteLine(n3);


    }

    static void CallDispose(IDisposable o)
    {
        o.Dispose();
    }







}
public class Box<T>
    // where T : struct
{
    public readonly T Value;

    public Box(T value)
    {
        Value = value;
    }
    public override string ToString() => Value.ToString() ?? "";
    public new string GetType() => "int";
}
