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
        Activity a = new AcademicActivity();
        a.Start();
    }






}



public class AcademicActivity : Activity
{
    public override void Start()
    {
        WriteLine("This is an academic activity");
        base.Start();
        
    }
}
public class Activity
{
    protected private int count = 4;
    public virtual void Start()
    {
        WriteLine("Starting activity");
    }
}