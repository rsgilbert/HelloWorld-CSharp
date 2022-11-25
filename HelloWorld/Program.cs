using static System.Console;
using static System.Math;
using System.Linq.Expressions;

public class Program
{


    static void Main(string[] args)
    {
        var unev = new UnEventful();
        unev.Announcement += s => 
        {
            WriteLine($"Announcement made {s}");
        };
        unev.Announcement += s => 
        {
            WriteLine($"Incase you didnt here: {s}");
        };

        unev.add_Annoucement2(s => WriteLine($"I want you to know that {s}"));
        unev.Announce("Someone is getting married tomorrow!");
     

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
