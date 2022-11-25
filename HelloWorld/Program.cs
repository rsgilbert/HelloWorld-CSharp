using static System.Console;
using static System.Math;

public class Program
{


    static void Main(string[] args)
    {
        int[] bins = { 0, 0, 0, 1, 2, 3, 4 };
        int idx = GetIndexOfFirstNonEmptyBin(bins);
        WriteLine(idx);

        EventHandler clickHandler = delegate {
            WriteLine("Clicked");
        }

    }

    public static int GetIndexOfFirstNonEmptyBin(int[] bins)
    {
        return Array.FindIndex(
            bins,
            (int v) =>
            {
                return v > 0;
            }
        );
    }




}


