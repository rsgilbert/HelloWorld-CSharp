using static System.Console;
using static System.Math;





class Program
{
    static void Main(string[] args)
    {
        // Item i1 = new Item(500);
        // i1.Print();

        // Item i2 = new Item(10, "Jack");
        // i2.Print();

        Console.WriteLine(Item.a);
    }

}

public class Item
{
    static Item()
    {
        Console.WriteLine("Static constructor here");
        Console.WriteLine($"a {a} b {b} c {c}");
    }
    public static int a = b + 1;
    private static int b = 100;
    private static int c = b + 1;
    public Item()
    {
        _price = 0;
        _name = "Unknown item";
    }
    public Item(decimal price)
        : this()
    {
        _price = price;
    }
    public Item(decimal price, string name) : this(price)
    {
        _name = name;
    }

     
    private readonly decimal _price;
    private readonly string _name;

    public void Print() 
    {
        WriteLine($"Price {_price}, Name {_name}");
    }
}