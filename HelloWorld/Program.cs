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

        var categories = Course.Catalog.Select(c => c.Category).Distinct();

        foreach (string category in categories)
        {
            // WriteLine(category);
        }

        var arr1 = new string[] { "james", "peterson", "john", "james" };
        var arr2 = new string[] { "mary", "sarah", "john", "peterson", "angella" };

        // Print(arr1.Concat(arr2));
        // Print(arr1.Append("Emmanuel"));
        // Print(arr2.Prepend("Antony"));

        var couples = arr1.Zip(arr2, (first, second) => string.Join(" is married to ", first, second));
        Print(couples);
        string[] arr3 = { "magret", "angella", "MONICA" };
        string[] arr4 = { "magret", "angella", "monica" };
        WriteLine(arr3.SequenceEqual(arr4, new IgnoreCaseComparer()));
    }

    static void Print<T>(IEnumerable<T> enumerable)
    {
        foreach (var item in enumerable)
        {
            WriteLine(item);
        }
    }

    private class IgnoreCaseComparer : EqualityComparer<string>
    {
        public override bool Equals(string? s1, string? s2)
        {
            return s1?.ToLower() == s2?.ToLower();
        }
  
        public override int GetHashCode(string s1)
        {
            return s1.GetHashCode();
        }
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
    public override string ToString()
    {
        return $"Course(Title={Title}, Category={Category})";
    }



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
            PublicationDate = new DateTime(2015, 5, 21),
            Duration = TimeSpan.FromHours(2),
        },
        new Course
        {
            Title = "Theory of Computation",
            Category = "CS",
            Number = 104,
            PublicationDate = new DateTime(2015, 5, 21),
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