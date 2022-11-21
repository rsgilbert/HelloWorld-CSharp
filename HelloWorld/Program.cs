using static System.Console;
using static System.Math;
using System.Windows;
using System.Numerics;
using System.Diagnostics;
// using System.Collections;
using System.Net.Http;

public class Program
{
  
    static void Main(string[] args)
    {
        WeakCache<string, string> cache = new WeakCache<string, string>();
        AddData(cache);
        if(cache.TryGetValue("one", out var result))
        {
            WriteLine($"One is {result}");
        }    
        result = null;
        GC.Collect();
        if(cache.TryGetValue("one", out var result2))
        {
            WriteLine($"One is {result2}");
        }    
        else 
        {
            WriteLine("No value at the key one");
        }
    
    }

    private static void AddData(WeakCache<string, string> cache)
    {
         cache.Add("one", new string("Jonah"));
    }





}

public class WeakCache<TKey, TValue> where TKey : notnull where TValue : class
{
    private readonly IDictionary<TKey, WeakReference<TValue>> _cache
        = new Dictionary<TKey, WeakReference<TValue>>();

    public void Add(TKey key, TValue value)
    {
        _cache.Add(key, new WeakReference<TValue>(value));
    }
    public bool TryGetValue(TKey key, out TValue? cachedValue)
    {
        cachedValue = null;
        if (_cache.TryGetValue(key, out WeakReference<TValue>? weakValue))
        {
            var isAlive = weakValue.TryGetTarget(out cachedValue);
            if(!isAlive)
            {   
                _cache.Remove(key);
            }
        }
        return _cache.ContainsKey(key);
    }

}


