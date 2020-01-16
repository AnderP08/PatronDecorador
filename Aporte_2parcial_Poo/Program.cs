using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aporte_2parcial_Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrozConPollo arrozConPollo = new ArrozConPollo();
            Console.WriteLine(arrozConPollo.Descripcion());
            Console.WriteLine(arrozConPollo.DescripcionExtra());
            Console.WriteLine(arrozConPollo.Total());
            Console.WriteLine();

            ArrozConCarne arrozConCarne = new ArrozConCarne();
            Console.WriteLine(arrozConCarne.Descripcion());
            Console.WriteLine(arrozConCarne.DescripcionExtra());
            Console.WriteLine(arrozConCarne.Total());

            Console.ReadKey();
        }
    }
}
