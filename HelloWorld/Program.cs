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
        IList<string> strings = new[] { "Jeff", "Simon", "Jeff", "Jeff", "Peter", "Simon", "Jeff"};
        ShowEachDistinctString(strings);

        ISet<int> nums1 = new HashSet<int>()
        {
            8, 6,1,2,3,5
        };
        foreach(int n in nums1)
        {
            WriteLine(n);
        }

        WriteLine("** ordered *");
        ISet<int> nums2 = new SortedSet<int>()
        {
            6,32,7,21,4,68,3
        };
         foreach(int n in nums2)
        {
            WriteLine(n);
        }
    
    }

    public static void ShowEachDistinctString(IList<string> strings)
    {
        ISet<string> shown = new HashSet<string>();
        foreach(string s in strings)
        {
            if(shown.Add(s))
            {
                WriteLine($"Not a duplicate: {s}");
            }
            else 
            {
                WriteLine($"Duplicate found: {s}");
            }
        }
        WriteLine($"{strings.Count-shown.Count}/{strings.Count} are duplicates");

        
    }


}
