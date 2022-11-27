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

        double averageHours = Course.Catalog.Average(cs => cs.Duration.TotalHours);
        double totalHours = Course.Catalog.Sum(cs => cs.Duration.TotalHours);
        double minHours = Course.Catalog.Min(cs => cs.Duration.TotalHours);
        DateTime maxDate= Course.Catalog.Max(cs => cs.PublicationDate);
        var courseWithMaxPubDt = Course.Catalog.MaxBy(cs =>cs.PublicationDate);
        WriteLine($"Average: {averageHours}, total {totalHours}, minHours {minHours}");

        WriteLine($"maxdate {maxDate}, cs {courseWithMaxPubDt}");

        double tot1 = Course.Catalog.Aggregate(0D, (hours, course) => hours + course.Duration.TotalHours);
        WriteLine(tot1);
        WriteLine(new DateTime());

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