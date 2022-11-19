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
        
        MyClass m = new MoreAdvancedClass();
        m.Hello();
        ((MoreAdvancedClass) m).fire();
        var d = m as MyDisposableAdvancedClass;
        WriteLine(d == null);
        var e = m as MoreAdvancedClass;
        WriteLine(e == null);
        e?.fire();

        if(m is MoreAdvancedClass moreAdv)
        {
            moreAdv.fire();
        }
    }

   


}

public class Jaguar {}

public class MoreAdvancedClass : MyAdvancedClass 
{
    public  void fire()
    {
        WriteLine("Firing");
    }
}

public class MyAdvancedClass : MyClass
{

}

public class MyDisposableAdvancedClass : MyClass, IDisposable
{
    public void Dispose() {}
}


public class MyClass
{
    public void Hello()
    {
        WriteLine("Hello");
    }
}