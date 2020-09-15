using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai_2020_09_15
{
    class Kor
    {
        int r;
        public Kor(int sugar)
        {
            r = sugar;
        }
        public double Kerulet()
        {
            return 2 * r * Math.PI;
        }
        public double Terulet()
        {
            return Math.Pow(r,2) * Math.PI;
        }
    }
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
            oldal.a = int.Parse(Console.ReadLine());
            oldal.b = int.Parse(Console.ReadLine());
            Console.WriteLine("A téglalap kerülete: {0}",oldal.Kerulet());
            Console.WriteLine("A téglalap területe: {0}", oldal.Terulet());
            Console.WriteLine();
            Console.WriteLine("Irja be a kör sugarát");
            Kor er = new Kor(int.Parse(Console.ReadLine()));
            //er.r = int.Parse(Console.ReadLine());
            Console.WriteLine("A kör kerülete: {0}", er.Kerulet());
            Console.WriteLine("A kör területe: {0}", er.Terulet());
            Console.ReadKey();
        }
    }
}
