using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace _13760_kolokwium_programowanie_obiektowe
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            var d1 = new Delegat(Potega);
            d1 += new Delegat(Potega2);
            d1(2, 3);
            // 2 
            double[] tab = new double[10000];

            Stopwatch s1 = Stopwatch.StartNew();

            foreach (var i in tab)
            {
                Console.Write(i+10+", ");
            }
            s1.Stop();
            Stopwatch s2 = Stopwatch.StartNew();
            Parallel.ForEach(tab, i =>
            {
                Console.Write(i + 10 + ", ");
            });
            s2.Stop();
            Console.WriteLine("program 1 - "+s1.Elapsed);
            Console.WriteLine("program 2 - "+s2.Elapsed);

        }
        // 1 
        static public void Potega(int x, int y)
        {
            Console.WriteLine(Math.Pow(x, y));
        }
        public delegate void Delegat(int x, int y);
        static public void Potega2(int x, int y)
        {
            Console.WriteLine(Math.Pow(y, x));
        }
        


    }
}
