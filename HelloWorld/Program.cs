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
        IBoth2 b = new IBoth2Impl();
        b.Base1Log();
        b.Base2Log();
        b.BothLog();
        b.Both2Log();
        
 
    }

   


}


interface IBase1 
{
    void Base1Log()

  ;
}

interface IBase2 
{
    void Base2Log()
    {
        WriteLine("I am base 2");
    }

}

interface IBoth : IBase1, IBase2
{
    void BothLog()
    {
        WriteLine("I am both");
    }

}

interface IBoth2 : IBoth 
{
    void Both2Log()
    {
        WriteLine("I am both 2");
    }
}

class IBoth2Impl : IBoth2 
{

    public void Base1Log()
    {
        WriteLine("I am really base 1");
    }
}



