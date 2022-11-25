using static System.Console;
using static System.Math;
using System.Linq.Expressions;

public class Program
{


    static void Main(string[] args)
    {
        Expression<Func<int, bool>> greaterThanZero = value => value > 0;
WriteLine(greaterThanZero);
     

    }




}


