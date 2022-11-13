using static System.Console;
using static System.Math;
using System.Windows;

public partial class Program
{
    static void Main(string[] args)
    {
        House h1 = Deferred<House>.Instance;
        WriteLine($"height is {h1.Height}");
        House h2 = Deferred<House>.Instance;
        WriteLine($"height for h2 is {h2.Height}");

    }

}

public static class Deferred<T>
    where T : new()
{
    private static T? _instance;


    public static T Instance 
    {
        get 
        {
            if(_instance == null)
            {
                _instance = new T();
            }
            return _instance;
        }
    }
}

public class House 
{

    public House()
    {
        WriteLine("Constructing a new house");
    }
    public int Height => 10;
}






