using static System.Console;
using static System.Math;
using System.Windows;
using System.Numerics;
using System.Diagnostics;
// using System.Collections;

public partial class Program
{
    static void Main(string[] args)
    {
       char[] letters = { 'a', 'b', 'c', 'd'};
       char b = letters[^3];
       int two = 2;
       char c = letters[^two];

       WriteLine($"{b}, {c}");

       char[] sub = letters[2..3];
       Index last = ^1;
       WriteLine($"{sub[0]}, {sub.Length}, {^1}, {letters[last]}");
       

        var ages = new[] {10, 20, 30, 40, 50, 60};
        var lastSub = ages[3..^0];
        WriteLine($"{lastSub[0]}, {lastSub[2]}");

        var name = "Jonathan Ions";
        var lastName = name[(1+name.IndexOf(" "))..];
        WriteLine(lastName);

        // array segment
        string[] colors = new[] {"red", "green", "yellow", "blue", "orange"};
        ArraySegment<string> colorsSegment = colors;
        ArraySegment<string> middleColors = colorsSegment[1..^1];
        WriteLine($"{middleColors[0]}, {middleColors[1]}");
        middleColors[0] = "Black";
        WriteLine(colors[1]);

        // span 
        int[] tenNums = {10,11,12,13,14,15,16,17,18,19};
        Span<int> allTen = tenNums;
        Span<int> secondHalf = allTen[4..10];
        WriteLine(secondHalf[^1]);
        secondHalf[^1] = 1999;
        ReadOnlySpan<int> readonlyFirstHalf = tenNums.AsSpan(0..5);
        WriteLine($"first length {readonlyFirstHalf.Length}");
        WriteLine(readonlyFirstHalf[0]);

        WriteLine(new Index(3, fromEnd:true).GetOffset(5));

        var myIndexable = new MyIndexable();
        WriteLine(myIndexable[2]);
        WriteLine(myIndexable[^2]);

        var myIndexable1 = myIndexable[0..^4];
        WriteLine(myIndexable1[^1]);



    }

    private class MyIndexable 
    {
        public char this[int index] => (char) ('0' + index);

        public int Count => 5;

        public MyIndexable Slice(int offset, int length) 
        {
            WriteLine($"offset {offset}, length {length}");
            return this;
        }
    }
 


}


