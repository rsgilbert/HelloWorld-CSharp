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
        var dv = new DisposableValue();
        WriteLine("passing value variable to method");
        CallDispose(dv);
        CallDispose(dv); // still disposing for first time cuz the box created for the argument uses a copy of the value variable
        CallDispose(dv);

        WriteLine("passing interface variable to method");
        IDisposable idisp = dv;
        CallDispose(idisp);
        CallDispose(idisp);
        idisp.Dispose();
        dv.Dispose();

        WriteLine("Calling directly on value variable");
        dv = new DisposableValue();
        dv.Dispose();
        dv.Dispose();
        dv.Dispose();
       
       WriteLine("passing value variable to method");
        CallDispose(dv);
        CallDispose(dv);
        CallDispose(dv);



    }

    static void CallDispose(IDisposable o)
    {
        o.Dispose();
    }

    

    

    
    
}

public struct DisposableValue: IDisposable
{
    private bool _disposedYet;

    public void Dispose()
    {
        if(!_disposedYet)
        {
            WriteLine("Disposing for first time");
            _disposedYet = true;
        }
        else 
        {
            WriteLine("Was already disposed");
        }
    }
}



