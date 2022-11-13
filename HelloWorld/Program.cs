using static System.Console;
using static System.Math;
using System.Windows;

public class Program
{
    static void Main(string[] args)
    {
       var d = new Dictionary<string, int> 
       {
        ["one"] = 1,
        ["t"] = 5
       };
       WriteLine(d["t"]);
       
    }

}

// indexer
public class HarryPotter
{
    public string this[int index]
    {
        get
        {
            switch (index)
            {
                case 1: return "Sorcerer's Stone";
                case 2: return "Chamber of Secrets";
                case 3: return "Prizoner of Azkaban";
                default: throw new Exception("Unknown");
            }
        }
    }
}

public struct Mansion
{
    public House House { get; set; }
}

public class House
{
    private double _height;

    public House() { }
    public House(double width)
    {
        Width = width;
    }

    public double Height
    {
        get
        {
            WriteLine($"_height is {_height}");
            return _height * 1000;
        }
        set
        {
            WriteLine($"value is {value}");
            _height = value / 1000;
        }
    }

    public double Width { get; private set; } = -1;

    public double BaseArea => Width * Height;



}
