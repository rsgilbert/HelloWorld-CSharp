using System.Diagnostics;
using System.Numerics;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BigInteger i1 = 1;
            BigInteger i2 = 1;

            Console.WriteLine(i1);
            int count = 0;

            while(true && count < 400_000)
            {
                if(count++ % 100_000 == 0)
                {
                    Console.WriteLine("i2 is " + i2);
                }
                BigInteger next = i1 + i2;
                i1 = i2;
                i2 = next;
            }
        }

    }
    
}





