using static System.Console;
using static System.Math;
using System.Linq.Expressions;

public class Program
{



    static void Main(string[] args)
    {
        Comparison<string> lengthComparison = (s1, s2) =>
            Math.Sign(s1.Length - s2.Length);

        string str1 = "Josephine";
        string str2 = "Kalypso";
        string str3 = "Zan";
        string str4 = "Nina Myers";
        string str5 = "Zi";
        string[] names = { str1, str2, str3, str4 , str5};
        Array.Sort(names, lengthComparison);
        foreach (string nm in names)
        {
            WriteLine(nm);
        }

        // sort using first char comparer
        // WriteLine("***** First char comparer *****");
        // Array.Sort(names, new FirstCharComparer());
        //  foreach (string nm in names)
        // {
        //     WriteLine(nm);
        // }

        // using first char comparer but as delegate
        WriteLine("***** First char comparer but as delegate *****");
        Array.Sort(names, new FirstCharComparer().Compare);
         foreach (string nm in names)
        {
            WriteLine(nm);
        }
    }
    
    private class FirstCharComparer : IComparer<string>
    {
        public int Compare(string? s, string? t)
        {
            if(s == null) return -1;
            if(t == null) return -1;
            return Math.Sign(s[0] - t[0]);
        }
    }



}


public class UnEventful
{
    public event Action<string>? Announcement;

    public void Announce(string message)
    {
        Announcement?.Invoke(message);
        Announcement2?.Invoke(message);
    }

    private Action<string>? Announcement2;

    public void add_Annoucement2(Action<string> action)
    {
        Announcement2 += action;
    }
}
