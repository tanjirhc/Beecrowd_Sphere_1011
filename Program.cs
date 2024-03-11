using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd_Sphere_1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R = Convert.ToDouble(Console.ReadLine());
            double Result = ((4 / 3.0) * 3.14159 * R * R * R);

            Console.WriteLine("VOLUME = {0:00.000}", Result);
            Console.ReadKey();
        }
    }
}
