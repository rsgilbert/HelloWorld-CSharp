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
        bool cb()
        {
            WriteLine("Hey there, you called me back!");
            return true;
        }
        // CallMeRightBack(cb);
        bool cbReturningFalse()
        {
            WriteLine("I return false when you call me, sir");
            return false;
        }

        NoArgCallback callbacks = cb;
        callbacks += cbReturningFalse;
        foreach (NoArgCallback c in callbacks.GetInvocationList())
        {
            WriteLine(c());
        }

    }

    public static void CallMeRightBack(NoArgCallback userCallback)
    {
        bool result = userCallback();
        WriteLine(result);
    }




}

public delegate bool NoArgCallback();
