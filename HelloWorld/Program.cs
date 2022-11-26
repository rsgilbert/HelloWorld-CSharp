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
        string[] names = { str1, str2, str3, str4 };
        Array.Sort(names, lengthComparison);
        foreach (string nm in names)
        {
            WriteLine(nm);
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
