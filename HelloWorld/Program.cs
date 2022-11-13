using static System.Console;
using static System.Math;





class Program
{
    static void Main(string[] args)
    {
        WriteLine(string.Format("{0}, {1}, {2}", 4, 5, 3));
        WriteLine($"Sum is {sum(10, 20, 30, 40)}");
    }

    static double sum(params double[] values)
    {
        double c = 8;
        InitializeResult(out double result);
        foreach(double v in values)
        {
            result = Incremented(result, v);
        }
        return result;

        static void InitializeResult(out double result)
        {
            result = 0;
        }
        double Incremented(double num, double byAmount) => num + byAmount;
    }

}