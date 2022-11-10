using System.Diagnostics;
using System.Numerics;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 3;
            int y = 5;
            int mx = (x > y) ? x : y;
            Console.WriteLine(mx);

            string msg = null;
            string finalMsg = msg ?? "No message";
            Console.WriteLine(finalMsg);
            Console.WriteLine(msg?.Length ?? -1);


        }

    }

}





