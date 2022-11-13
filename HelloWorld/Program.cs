using static System.Console;
using static System.Math;
using System.Windows;

public class Program
{
    static void Main(string[] args)
    {
        INamed h2 = new HumanName();
        WriteLine(h2.Name);

        INamed inamed0 = new HumanName();
        WriteLine(inamed0.FindOutcome());
        WriteLine(INamed.TheMagicWord);
        

    }
}

public class HumanName : INamed 
{
    public int Id => 4;
    // public string Name => "James";
}

public interface INamed 
{
    int Id { get; }
    public const string TheMagicWord = "Avada Kedavra";

    public enum Outcome { Yes, No };
    string Name => $"{this.GetType()}: {this.Id}";

     Outcome FindOutcome()
    {
        return Outcome.Yes;
    }
}