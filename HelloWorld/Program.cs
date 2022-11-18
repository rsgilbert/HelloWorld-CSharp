using static System.Console;
using static System.Math;
using System.Windows;
using System.Numerics;
using System.Diagnostics;
using System.Collections;

public partial class Program
{
    static void Main(string[] args)
    {
       var houses = new Houses();
       foreach(string h in houses)
       {
        WriteLine(h);
       }

       var houses2 = new Houses();
       var enumerator = houses2.GetEnumerator();
       while(enumerator.MoveNext())
       {
            string h = enumerator.Current;
            WriteLine(h);
       } 
    WriteLine(enumerator.Current);
    WriteLine(enumerator.MoveNext());


    }



}



public class Houses : IEnumerable<string>
{
    public IEnumerator<string> GetEnumerator()
    {
        return new HouseEnumerator("Nateete", "Salaama", "Kyebando");
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return new HouseEnumerator("Nateete", "Salaama", "Kyebando");
    }

    private class HouseEnumerator : IEnumerator<string>
    {
        private string _house1, _house2, _house3;
        private string _currentHouse = "";
        private int _idx = -1;
        public HouseEnumerator(string house1, string house2, string house3)
        {
            _house1 = house1;
            _house2 = house2;
            _house3 = house3;
        }
        public string Current => _currentHouse;
        object IEnumerator.Current => _currentHouse;

        public void Dispose()
        { }

        public bool MoveNext()
        {
            _idx++;
            switch (_idx)
            {
                case 0:
                    _currentHouse = _house1;
                    return true;
                case 1:
                    _currentHouse = _house2;
                    return true;
                case 2:
                    _currentHouse = _house3;
                    return true;
                default:
                    _currentHouse = "";
                    return false;
            }
        }

        public void Reset()
        {
            throw new NotSupportedException();
        }
    }

}
