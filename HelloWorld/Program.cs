using System.Diagnostics;


namespace HelloWorld
{
    public class Program
    {
        [Conditional("RELEASE")]
        static void ShowDebugInfo()
        {
            Console.WriteLine("I am allowed to show debug info2");
        }
     
        public static void Main(string[] args)
        {
#pragma warningm disable
            var i = 10;

            Console.WriteLine("Done 29");
            ShowDebugInfo();
#if false
#error We do not support this version
#endif
        }
    }
}




