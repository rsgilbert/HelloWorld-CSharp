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
        Queue<int> q1 = new Queue<int>();
        q1.Enqueue(1);
        q1.Enqueue(20);
        q1.Enqueue(30);

        WriteLine(q1.Peek());
        WriteLine(q1.Dequeue());
        WriteLine(q1.Peek());
        WriteLine($"Count {q1.Count}");
        int[] arr = q1.ToArray();
        WriteLine(arr[0]);

        Stack<string> s1 = new Stack<string>();
        s1.Push("John");
        s1.Push("Simon");


        WriteLine(s1.Peek());
        WriteLine(s1.Pop());
        if(s1.TryPop(out string? result))
        {
            WriteLine($"Result {result}");
        }
        WriteLine(s1.Count);
    }

   


}
