using static System.Console;
using static System.Math;
using System.Globalization;
public class Program
{
    static void Main(string[] args)
    {
        IEnumerable<CultureInfo> commaCultures =
            from culture in CultureInfo.GetCultures(CultureTypes.AllCultures)
            where culture.NumberFormat.NumberDecimalSeparator == "." 
                && culture.NumberFormat.NumberDecimalDigits == 3
                && culture.ToString().StartsWith("en")
            select culture;
        foreach(CultureInfo culture in commaCultures)
        {
            // WriteLine(culture);
        }


        string[] colors = { "green", "yellow", "indigo", "violet", "blue", "red", "Black", "Brown"};
        // query expression syntax
        var shortColors = from color in colors 
            where color.Length <= 4
            select (color.Length, color);
        foreach(var c in shortColors)
        {
            WriteLine(c);
        }

        // chained method calls
        var longColorNames = colors.Where(c => c.Length >= 6).Select((c, i) => (i, c.Length, c));
        foreach(var c in longColorNames)
        {
            WriteLine(c);
        }


        //  b colors 
        var bColors = from color in colors 
            let lowercaseColor = color.ToLower()
            where lowercaseColor.StartsWith("b")
            select (color, lowercaseColor);
         foreach(var c in bColors)
        {
            WriteLine(c);
        }

        WriteLine("*** using loud provider");
        var q = from lp in new LoudProvider()
            where lp == "Chimpanzee"  // lp's type is deduced from the delegate in LoudProvider#Where
            select lp.Substring(0, 6);
        WriteLine(q);


     }

    
}


public class LoudProvider 
{
    public LoudProvider Where(Func<string,bool> pred)
    {
        WriteLine("So you want to filter out something, huh");
        return this;
    }

    public T Select<T>(Func<string, T> map)
    {
        WriteLine($"There you go. You selected it {typeof(T)}");
        return map("Gone are the days");
    }
}