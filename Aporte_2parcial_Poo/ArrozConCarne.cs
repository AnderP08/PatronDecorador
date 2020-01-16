using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aporte_2parcial_Poo
{
    class ArrozConCarne : IPlato, IExtra
    {
        public string Descripcion()
        {
            return "arroz con carne";
        }

        public string DescripcionExtra()
        {
            return "ensalada";
        }

        public decimal Precio()
        {
            return 2.25M;
        }

        public decimal PrecioExtra()
        {
            return 0.25M;
        }

        public decimal Total()
        {
            return Precio() + PrecioExtra();
        }
    }
}
