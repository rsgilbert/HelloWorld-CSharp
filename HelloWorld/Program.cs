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
        var studentsAndCourses =
            from choice in CourseChoice.ChoiceCatalog
            join course in Course.Catalog
            on choice.Number equals course.Number
            orderby choice.Number
            select new { course.Number, course.Title, choice.StudentId };
        Print(studentsAndCourses);

        var orders = new[]
        {
            new { OrderId=1, Description="Pilao"},
            new { OrderId=2, Description="Chips"},
            new { OrderId=3, Description="Macron"}
        };
        var orderLines = new[]
        {
            new { DocumentNo =1, Qty=2,Description="Rice"},
            new { DocumentNo=2, Qty=1, Description="Chip slices"},
            new {DocumentNo=2, Qty=2, Description="Tomato sauce"},
            new {DocumentNo=3, Qty=1, Description="Macron"},
            new {DocumentNo=3, Qty=1, Description="Cola"}
        };

        var allOrders = 
            from order in orders 
            join orderLine in orderLines 
            on order.OrderId equals orderLine.DocumentNo 
            select new { order.OrderId, order.Description, LineDescription=orderLine.Description, orderLine.Qty};
        Print(allOrders);



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