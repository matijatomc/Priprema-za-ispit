using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaZadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, a, b, c;
            Console.WriteLine("Upiši a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upiši b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upiši c:");
            c = Convert.ToInt32(Console.ReadLine());

            x = (a + b + c) / 3;

            Console.WriteLine("Rješenje je:" + x);
            Console.ReadKey();
        }
    }
}
