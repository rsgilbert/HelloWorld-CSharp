using static System.Console;
using static System.Math;
using System.Windows;

public partial class Program
{
    static void Main(string[] args)
    {
        var housePrinter = new HousePrinter<FlatHouse>();
        var flat1 = new FlatHouse();
        housePrinter.Print(flat1);

        var simpleHousePrinter = new HousePrinter<IHouse>();
        simpleHousePrinter.Print(new SimpleHouse("My simple house"));

    }

}

public class HousePrinter<T>
    where T : IHouse
{
    public void Print(T t)
    {
        Console.WriteLine(t.description);
    }
}



public interface IHouse
{
    string description { get; set; }
}

public class FlatHouse : IHouse
{
    public string description { get; set; } = "This is a flat house";

}



public class SimpleHouse : IHouse 
{
    private string _description;
    public SimpleHouse(string description)
    {
        _description = description;
    }
    public string description { get { return _description; }set{}} 
}




