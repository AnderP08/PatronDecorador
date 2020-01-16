using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aporte_2parcial_Poo
{
    class ArrozConPollo : IPlato, IExtra
    {
        public string Descripcion()
        {
            return "arroz con pollo";
        }

        public string DescripcionExtra()
        {
            return "menestra de frejol";
        }

        public decimal Precio()
        {
            return 2.00M;
        }

        public decimal PrecioExtra()
        {
            return 0.15M;
        }

        public decimal Total()
        {
            return Precio() + PrecioExtra();
        }
    }
}
