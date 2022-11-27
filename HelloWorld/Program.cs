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
        int[] numbers = {1,2,3,4,5};
        string[] letters = {"A", "B", "C"};

        IEnumerable<string> combined = from number in numbers 
            from letter in letters 
            select letter + number;
        
        IEnumerable<string> combined2 = numbers.SelectMany(
                number => letters, (number, letter) => letter + number
        );
        
        // foreach(string s in combined2) WriteLine(s);

        // flattening an array 
        int[][] arrays = 
        {
            new[] { 1, 4}, 
            new[] { 10, 20, 50, 60},
            new[] { 100, 100, 100, 101 }
        };
        var flattened = from row in arrays 
            from col in row 
            select col;
        WriteLine(string.Join(" , ", flattened));
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