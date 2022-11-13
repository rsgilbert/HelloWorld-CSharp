using static System.Console;
using static System.Math;
using System.Windows;

public  partial class Program
{
     static void Main(string[] args)
    {
        
        NamedContainer<int> container = new NamedContainer<int>(5, "jokes");
        WriteLine(container.Item);
        WriteLine(container.Name);

        NamedContainer<string> container2 = new NamedContainer<string>("Programming", "book");
        WriteLine(container2.Item);

    }
    
}

public class NamedContainer<T> 
{
    public NamedContainer(T item, string name)
    {
        Item = item;
        Name = name;
    }

    public T Item { get; }
    public string Name {get; }
}

public class NamedContainer<T,U> 
{
    public NamedContainer(T item, string name)
    {
        Item = item;
        Name = name;
    }

    public T Item { get; }
    public string Name {get; }
}
