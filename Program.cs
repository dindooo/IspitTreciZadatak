using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspitTreci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prvi, drugi = 1, sljedeci, brojElemenata;
            Console.WriteLine("Upisite koliki broj elemenata zelite");
            brojElemenata = int.Parse(Console.ReadLine());
            Console.WriteLine("Upisite pocetni broj");
            prvi = int.Parse(Console.ReadLine());
            Console.WriteLine(prvi+" "+drugi+" ");
            for(int i=2; i<brojElemenata; i++)
            {
                sljedeci = prvi + drugi;
                Console.WriteLine(sljedeci + " ");
                prvi = drugi;
                drugi = sljedeci;
            }
            Console.ReadKey();
        }
    }
}
