using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aporte_2parcial_Poo
{
    /*  Decorator(decorador)
     *  existe un restaurante donde solo se sirven dos tipo de comida
     *  el decorador permitirá expandir el menu del plato con su respectivo precio.
     */

    interface IPlato
    {
        string Descripcion();
        decimal Precio();

    }
}
