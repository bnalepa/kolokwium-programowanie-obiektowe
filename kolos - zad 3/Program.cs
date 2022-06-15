using System;
using System.Collections.Generic;
namespace kolos___zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Metoda<int>(6, 5);
            Metoda<int>(4, 5);
            Metoda<int>(5, 5);
        }


        static public void Metoda<T>(T x1, T x2) where T: IComparable
        {
            switch(x1.CompareTo(x2))
            {
                case < 0:
                    Console.WriteLine(x2);
                    break;
                case > 0:
                    Console.WriteLine(x1);
                    break;
                 default:
                    Console.WriteLine("Są równe sobie");
                    break;

            }
        }
    }
}
