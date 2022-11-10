using System.Diagnostics;
using System.Numerics;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string workStatus = "ManagerInRoom";

            switch(workStatus)
            {
                case "ManagerInRoom":
                    Console.WriteLine("Work diligently");
                    goto case "DeadlineOvershot";
                case "HaveNonUrgentDeadline":
                case "HaveImminentDeadline":
                    Console.WriteLine("Check twitter");
                    Console.WriteLine("Check email");
                    break;
                case "DeadlineOvershot":
                    Console.WriteLine("Work furiously");
                    break;
                default:
                    Console.WriteLine("Chat");
                    break;
            }
        }

    }

}





