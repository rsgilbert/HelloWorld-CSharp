using static System.Console;
using static System.Math;
using System.Windows;
using System.Numerics;
using System.Diagnostics;


public partial class Program
{
    static void Main(string[] args)
    {
        // rectangular arrays
        int [,] grid = new int [3, 5]
        {
            {1,2,3,4,5},
            {6,7,8,9,10},
            {11, 12, 13,14,15}
        };
        int i = grid[1,3];
        WriteLine($"I expect {9}, I've got {i}");
        WriteLine(grid.Length); // total length 
        WriteLine(grid.GetLength(0));
        WriteLine(grid.GetLength(1));
    }






}

