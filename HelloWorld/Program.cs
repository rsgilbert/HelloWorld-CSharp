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
        MyBase cd = new CustomerDerived();
        cd.Start();
    }

   
 



}

public class CustomerDerived :MyBase 
{
    public override void Start()
    {
        WriteLine("start");
    }
}
public class MyBase 
{
    public  virtual void Start() {WriteLine("base start");}
}


public abstract class House2 : AbstractHouse 
{}

public abstract class AbstractHouse 
{
    public abstract void Build();
}