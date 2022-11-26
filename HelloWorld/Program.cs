using static System.Console;
using static System.Math;
using System;

public class Program
{
    static void Main(string[] args)
    {

        string[] colors = { "green", "yellow", "indigo", "violet", "blue", "red", "Black", "Brown" };

        //  b colors 
        var bColors = from color in colors
                    //   let lowercaseColor = color.ToLower()
                      where color.ToLower().StartsWith("b")
                      select color.AsSpan(0, 3).ToString();
        foreach (var c in bColors)
        {
            WriteLine(c);
        }

    }




}

public static class CustomLinqProvider
{
    public static string[] Where(this string[] arr, Predicate<string> filter)
    {
        WriteLine("Filtering array");
        return Array.FindAll(arr, filter);
    }
    public static T[] Select<T>(this string[] arr, Func<string, T> map)
    {
        WriteLine("Selecting...");
        var result = new T[arr.Length];
        for(int i = 0; i < arr.Length; i++)
        {
            result[i] = map(arr[i]);
        }
        return result;
    }
}