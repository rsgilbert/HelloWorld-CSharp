using static System.Console;
using static System.Math;
using System.Windows;

public class Program
{
    static void Main(string[] args)
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string[] files = Directory.GetFiles(path);
        var comparer = new LengthComparer();
        Array.Sort(files, comparer);
        foreach(string s in files)
        {
            WriteLine(s);
        } 

    }


    private class LengthComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            int diff = (x?.Length ?? 0) - (y?.Length ?? 0);
            return diff == 0 ? (x?.CompareTo(y) ?? 0) : diff;
        }
    }

}

