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
            if (sugar<1)
            {
                r = 1;
            }
            else
            {
                r = sugar;
            }
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
        int a, b;
        public Teglalap(int c, int d)
        {
            a = c;
            b = d;
        }      
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
            /*Teglalap oldal = new Teglalap();
            oldal.a = int.Parse(Console.ReadLine());
            oldal.b = int.Parse(Console.ReadLine());*/
            Console.WriteLine("Adja meg a téglalap oldalait");
            Teglalap valami = new Teglalap(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            //Console.WriteLine("A téglalap kerülete: {0}",oldal.Kerulet());
            //Console.WriteLine("A téglalap területe: {0}", oldal.Terulet());
            Console.WriteLine("A téglalap kerülete: {0}",valami.Kerulet());
            Console.WriteLine("A téglalap területe: {0}",valami.Terulet());
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
