using System.Diagnostics;
using System.Numerics;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char[] chars = {'c', 'a', 'f', (char) 0xe9, 's'};
            string text = new string(chars);
            Console.WriteLine(text);
            Console.WriteLine(text.Length);
            Console.WriteLine(new string(text.Reverse().ToArray()));

            string t2 = "cafés";
            Console.WriteLine(t2);
            Console.WriteLine(t2.Length);
        }

    }
    
}





