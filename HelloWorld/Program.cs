using static System.Console;
using static System.Math;
using System.Windows;

public class Program
{
    static void Main(string[] args)
    {
        DoStuff ds = new DoStuff();
        ds.Name = "James";
        WriteLine(ds.Name);

        IDoStuff ds2 = new DoStuff();
        WriteLine(ds2.Id);

        WriteLine(((IDoStuff) ds).Id );

    }


  
}

public class DoStuff : IDoStuff
{
    private string _name = "";
    public string this[int i] { get {return $"Index {i}";} set {} }
    public string Name { get {return _name; } set { _name = value; }}
    int IDoStuff.Id => 1;
    public int Hey(string other) 
    {
        Console.WriteLine($"Hey {other}");
        return 0;
    }
}

public interface IDoStuff 
{
    string this[int i] { get; set; }
    string Name { get; set; }
    int Id { get; }
    int Hey(string other);
    // event EventHandler Click;
}