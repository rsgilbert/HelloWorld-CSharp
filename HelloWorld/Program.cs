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
        Dictionary<string, string> names = new Dictionary<string, string>();
        names["simon"] = "Simon Peter";
        names["gilbert"] = "Gilbert Robert";
        names.Add("uk", "United Kingdom");
        names["uk"] = "Uniked";

        WriteLine(names["simon"]);
        WriteLine(names["uk"]);
        if(names.TryGetValue("gilbert", out string? fullName))
        {
            WriteLine($"Fullname is {fullName}");
        }
        

        var textToNum = new Dictionary<string,int>
        {
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
             {"one2", 1},
            {"two2", 2},
            {"three2", 3},
            {"four2", 4}
        };
        WriteLine(textToNum["one"]);
        foreach(var kvp in textToNum)
        {
            WriteLine($"{kvp.Key}={kvp.Value}");
        }

        IDictionary<char, string> letters = new Dictionary<char, string>
        {
            ['a'] = "A",
            ['d'] = "D",
            ['e'] = "E",
            ['b'] = "B",
            ['c'] = "C"
        };
        WriteLine(letters['a']);
        WriteLine(letters['b']);

        foreach(var pair in letters)
        {
            WriteLine(pair);
        }

        IDictionary<char, string> sortedLetters = new SortedDictionary<char, string>
        {
            ['a'] = "A",
            ['d'] = "D",
            ['e'] = "E",
            ['b'] = "B",
            ['c'] = "C"
        };
        WriteLine("*** Sorted ***");
        foreach(var pair in sortedLetters)
        {
            WriteLine(pair);
        }
        WriteLine("*** Sorted end ***");


        // ingore case in keys 
        var numberNames = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase)
        {
            ["one"] = 1,
            ["Two"] = 2,
            ["thReE"] = 3
        };
        WriteLine(numberNames["ONE"]);
        WriteLine(numberNames["three"]);

        
    


    }

  
  
 


}

public class UserCache 
{
    private readonly Dictionary<string, UserInfo> _cachedUserInfo = 
        new Dictionary<string, UserInfo>();

    public UserInfo GetInfo(string userHandle)
    {
        RemoveStaleCacheEntries();
        if(!_cachedUserInfo.TryGetValue(userHandle, out UserInfo? info))
        {
            info = FetchUserInfo(userHandle);
            _cachedUserInfo.Add(userHandle, info);
        }
        return info;
    }

    private UserInfo FetchUserInfo(string userHandle)
    {
        return new UserInfo();
    }

    private void RemoveStaleCacheEntries()
    {

    }
}


public class UserInfo 
{}