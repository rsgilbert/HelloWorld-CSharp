using static System.Console;
using static System.Math;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
public class Program
{
    static void Main(string[] args)
    {
        foreach(var course in Course.ShortEvenIdxCourses())
        {
            // WriteLine(course.Title);
        }
        // ShowAllStrings(srcObjects());

        var courses = from course in Course.Catalog 
            where course.Category == "CS"
            select new { course.Category, course.Title };
        foreach(var course in courses)
        {
            // WriteLine($"Category: {course.Category}, Title: {course.Title}");
        }

        // projection/mapping using select
        int[] numbers = { 0, 1, 2, 3, 4};
        int[] squared = (from number in numbers select number * number).ToArray();
        foreach(int sq in squared) WriteLine(sq);
    }
    public static void ShowAllStrings(IEnumerable<object> src)
    {
        foreach(var s in src.OfType<Female>())
        {
            WriteLine(s);
        }
    }

    public static IEnumerable<object> srcObjects()
    {
        yield return 5;
        yield return "Jack";
        yield return false;
        yield return "Chemistry";
        yield return new Person();
        yield return new Female();
        yield return new Person();
    }




}

public class Person
{
    public override string ToString()
    {
        return "I am a person";
    }
}

public class Female : Person 
{
    public override string ToString()
    {
        return "I am a female person";
    }
}

public class Course
{
    public string Title { get; set; } = "";
    public string Category { get; set; } = "";
    public int Number { get; set; }
    public DateTime PublicationDate { get; set; }
    public TimeSpan Duration { get; set; }

    

    public static IEnumerable<Course> ShortEvenIdxCourses()
    {
        return Catalog
            .Where((course, idx) => (idx % 2 == 0 && course.Duration.TotalHours < 3));
    }
    public static readonly Course[] Catalog =
    {
        new Course
        {
            Title = "Elements of Geometry",
            Category = "MAT",
            Number = 101,
            PublicationDate = new DateTime(2001, 3, 20),
            Duration = TimeSpan.FromHours(3),
        },
        new Course
        {
            Title = "Graph Theory",
            Category = "MAT",
            Number = 102,
            PublicationDate = new DateTime(2015, 5, 21),
            Duration = TimeSpan.FromHours(1),
        },
        new Course
        {
               Title = "Discrete Maths",
            Category = "MAT",
            Number = 103,
            PublicationDate = new DateTime(2014, 5, 21),
            Duration = TimeSpan.FromHours(2),
        },
        new Course
        {
            Title = "Theory of Computation",
            Category = "CS",
            Number = 104,
            PublicationDate = new DateTime(2017, 3, 2),
            Duration = TimeSpan.FromHours(5),
        },
        new Course
        {
               Title = "Data Structures and Algorithms",
            Category = "CS",
            Number = 104,
            PublicationDate = new DateTime(2017,11, 15),
            Duration = TimeSpan.FromHours(1),
        }
    };
}