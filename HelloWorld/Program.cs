using static System.Console;
using static System.Math;
using System.Windows;
using System.Numerics;
using System.Diagnostics;
// using System.Collections;

public class Program
{
    static void Main(string[] args)
    {
        LinkedList<string> list = new LinkedList<string>();
        list.AddFirst(new LinkedListNode<string>("Purple"));
        list.AddFirst(new LinkedListNode<string>("Green"));
        list.AddFirst(new LinkedListNode<string>("Yellow"));

        WriteLine(list.Count);
        WriteLine(list.First?.Value); // Yellow 
        WriteLine(list.Last?.Value);

        list.RemoveFirst();
        WriteLine(list.First?.Value);
        list.RemoveFirst();
        list.RemoveFirst();
        WriteLine(list.Count);
    }

   


}
