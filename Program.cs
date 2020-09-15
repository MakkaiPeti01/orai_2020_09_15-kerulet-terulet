using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai_2020_09_15
{
    class Teglalap
    {
        public int a, b;
        public int Kerulet()
        {
            return 2 * (a + b);
        }
        public int Terulet()
        {
            return a * b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Teglalap oldal = new Teglalap();           
            oldal.a = 10;
            oldal.b = 15;
            Console.WriteLine("A téglalap kerülete: {0}",oldal.Kerulet());
            Console.WriteLine("A téglalap területe: {0}", oldal.Terulet());
            Console.ReadKey();
        }
    }
}
