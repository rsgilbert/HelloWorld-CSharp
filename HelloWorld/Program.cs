using System.Diagnostics;
using System.Numerics;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] names = { "John", "Peter", "Jack", "Simon", "Liz" , "Simon"};

            ShowMessages(names);
        }

        public static void ShowMessages(IEnumerable<string> messages)
        {
            foreach (string message in messages)
            {
                Console.WriteLine(message);
            }
        }

    }

}





