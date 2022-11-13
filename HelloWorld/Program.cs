using static System.Console;
using static System.Math;
using System.Windows;

public class Program
{
    static void Main(string[] args)
    {
        var temp = PorridgeTemperature.TooHot;

        switch (temp)
        {
            case PorridgeTemperature.TooHot:
                WriteLine("too hot");
                break;
            case PorridgeTemperature.TooCold:
                WriteLine("very cold");
                break;
        }
        WriteLine(((int)temp));
        WriteLine($"Just right: {(int)PorridgeTemperature.JustRight}");

        WriteLine($"too cold: {(int)PorridgeTemperature.TooCold}");

        PorridgeTemperature hotOrCold = PorridgeTemperature.TooCold | PorridgeTemperature.TooHot;
        WriteLine(hotOrCold); // prints: TooHot, TooCold

        var v = hotOrCold & PorridgeTemperature.TooCold;
        WriteLine(v);


    }


    [Flags]
    public enum PorridgeTemperature: long
    {
        // order them as powers of 2 since they are bit flags
        TooHot = 1,
        TooCold = 2,
        JustRight = 4

    };
}