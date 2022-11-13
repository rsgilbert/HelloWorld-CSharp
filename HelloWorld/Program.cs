using static System.Console;
using static System.Math;





class Program
{
    static void Main(string[] args)
    {
        Blame(problem: "poverty");

    }

    public static void Blame(string perpertrator = " kids ", string problem = " the dirty environment")
    {
        Console.Write($"We blame {perpertrator} for {problem}.");

        // using var r = new StreamReader(stream, Encoding.UTF8, true, 8192, false);
        // using var r2 = new StreamReader(stream, Encoding.UTF8, detectEncodingFromByteOrderMarks: true, bufferSize:8192, leaveOpen: false);

        // using var w = new StreamWriter(filepath, append:true, Encoding.UTF8);

    }
}