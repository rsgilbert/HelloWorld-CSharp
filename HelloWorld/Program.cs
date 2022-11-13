using static System.Console;
using static System.Math;
using System.Windows;


public class Program
{
    static void Main(string[] args)
    {
        House house = new House();
        house.Height = 100;
        WriteLine($"House height is {house.Height}");
        // house.Width = 5; 
        WriteLine($"House width is {house.Width}");

        House house2 = new House(5);
        house2.Height = 3;
        WriteLine($"Base area is {house2.BaseArea}");

        Mansion m = new Mansion();
        m.House = new House(3);
        m.House.Height = 4;
        WriteLine(m.House.BaseArea);

        // look at indexers 
        var hp = new HarryPotter();
        WriteLine($"{hp[1]}");
        WriteLine($"{hp[3]}");
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
