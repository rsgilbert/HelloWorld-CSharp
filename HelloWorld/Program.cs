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
        Activity a = new AcademicActivity()
        {
            NoOfActivities = 55,
            NoOfTeachers = 3
        };
        a.Start();
    }






}



public class AcademicActivity : Activity
{
     private int _noOfTeachers;
     private int aa2 = SetV(8);
    public int NoOfTeachers
    {
        get
        {
            return _noOfTeachers;
        }
        set
        {
            WriteLine($"Setting no of Teachers to {value}");
            _noOfTeachers = value;
        }
    }
    public AcademicActivity() : base(10)
    {
        WriteLine("Constructing academic activity" + 10);

    }
    public override void Start()
    {
        WriteLine("This is an academic activity");
        base.Start();

    }
}
public class Activity
{
    public static int SetV(int a)
    {
        WriteLine($"Setting value {a}");
        return a * 2;
        
    }

    private int a1 = SetV(10);

    private int _noOfActivities;
    public int NoOfActivities
    {
        get
        {
            return _noOfActivities;
        }
        set
        {
            WriteLine($"Setting no of activities to {value}");
            _noOfActivities = value;
        }
    }
    public Activity()
    {
        WriteLine("Constructing activity");
    }
    public Activity(int i)
    {
        WriteLine("Constructing activity " + i);
    }
    protected private int count = 4;
    public virtual void Start()
    {
        WriteLine("Starting activity");
    }
}

