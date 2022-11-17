using static System.Console;
using static System.Math;
using System.Windows;
using System.Numerics;
using System.Diagnostics;


public partial class Program
{
    static void Main(string[] args)
    {
        var nums = new List<int>();
        nums.Add(100);
        nums.Add(88);
        nums.Add(17);
        WriteLine(nums.Count);
        nums[1]++;
        WriteLine(nums[1]);

        nums.RemoveAt(1);
        WriteLine(nums.Count);
        WriteLine(nums[1]);

        var ages = new List<int>{10, 20, 30};
        WriteLine(ages[2]);


        var ar = new int[] {8, 7, 3, 1, 5};
        var ns =new List<int>(ar);
        WriteLine(ar[2]);




    }






}

