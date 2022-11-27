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
        var tenTo15 = Enumerable.Range(10, 5);
        Print(tenTo15);

        var fourSevens = Enumerable.Repeat(7, 4);
        Print(fourSevens);

        IEnumerable<int> emptyEn = Enumerable.Empty<int>();
        WriteLine(emptyEn.Count());




    }

    static void Print<T>(IEnumerable<T> enumerable)
    {
        foreach (var item in enumerable)
        {
            WriteLine(item);
        }
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
            Title = "Data Structures and Algorithms",
            Category = "CS",
            Number = 104,
            PublicationDate = new DateTime(2017,11, 15),
            Duration = TimeSpan.FromHours(1),
        },
        new Course
        {
            Title = "Graph Theory",
            Category = "SE",
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

    };


}

public class CourseChoice
{
    public int StudentId { get; set; }
    public int Number { get; set; }

    public static CourseChoice[] ChoiceCatalog =
    {
        new CourseChoice{ StudentId = 1, Number = 101 },
        new CourseChoice { StudentId = 1, Number = 103 },
        new CourseChoice{ StudentId = 2, Number = 101 },
        new CourseChoice { StudentId = 2, Number = 105},
        new CourseChoice{ StudentId = 3, Number = 101 },
        new CourseChoice { StudentId = 4, Number = 103 },
        new CourseChoice{ StudentId = 4, Number = 104 },
        new CourseChoice { StudentId = 4, Number = 105},
    };
}