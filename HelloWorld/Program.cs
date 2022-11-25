using static System.Console;
using static System.Math;
using System.Windows;
using System.Numerics;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Reflection;

public class Program
{


    static void Main(string[] args)
    {
        //  illustrating contravariance
        MyPredicate<object> po = IsLongString;
        MyPredicate<string> ps = po;
        WriteLine($"is long: {ps("Jamesm")}");

        // illustrating covariance
        MyFunc<string, string> fb = Capitalize;
        MyFunc<string, object> fo = fb;

       
        string s = "FJ";
        object o = s;
    }

    public static string Capitalize(object o) 
    {
        return o?.ToString()?.ToUpper() ?? "";
    }

    public static bool IsLongString(object o)
    {
        return o is string s && s.Length > 5;
    }
    



}

// TResult is covariant
// This means that if can  implicitly convert from string to object,
// Then you can implicitly convert from MyFunc<string, string> to MyFunc<string, object>
// Simply saying: If it can output a string, then its okay to save the string as an object. 
public delegate TResult MyFunc<in T,  out TResult>(T arg);

// the T type argument in MyPredicate is contravariant.
// This means that if you can implicitly convert from string to object,
// then you can implicitly convert from MyPredicate<object> to MyPredicate<string>
// Simply saying: If it can work on any object, then it can work on any string as well.
// <in T> is like saying: accepts any kind of T
public delegate bool MyPredicate<in T>(T t);