using static System.Console;
using static System.Math;
using System;
using System.Collections.Generic;
using System.Numerics;
// using System.Linq;
public class Program
{
    static void Main(string[] args)
    {
        var evenFib = from n in Fibonacci() 
            where n % 2 == 0 
            select n;
        foreach(BigInteger n in evenFib)
        {
            if(n > 1000) return;
            WriteLine(n);
        }
    }

    static IEnumerable<BigInteger> Fibonacci()
    {
        BigInteger n1 = 1;
        BigInteger n2 = 1;
        yield return n1; 
        while(true)
        {
            yield return n2;
            BigInteger temp = n1;
            n1 = n2;
            n2 = temp + n2;
        }
    }




}

public static class BigIntegerLinqProvider 
{
    public static IEnumerable<BigInteger> Where(this IEnumerable<BigInteger> en, Predicate<BigInteger> filter)
    {
        WriteLine("Filtering");
        foreach(var bi in en)
        {
            if(filter(bi))
            {
                yield return bi;
            }
        }
        
    }
}

// public static class CustomLinqProvider
// {
//     public static string[] Where(this string[] arr, Predicate<string> filter)
//     {
//         WriteLine("Filtering array");
//         return Array.FindAll(arr, filter);
//     }
//     public static T[] Select<T>(this string[] arr, Func<string, T> map)
//     {
//         WriteLine("Selecting...");
//         var result = new T[arr.Length];
//         for(int i = 0; i < arr.Length; i++)
//         {
//             result[i] = map(arr[i]);
//         }
//         return result;
//     }
// }