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
      var arr = new[] {"John", "Dike"};
      IList<string> l = arr;
      WriteLine(l.IndexOf("Dike"));
      WriteLine(l[0]);
      
      IReadOnlyList<string> r = (IReadOnlyList<string>) l;
      WriteLine(r[1]);

    }



}


