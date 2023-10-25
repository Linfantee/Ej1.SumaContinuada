using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.SumaContinuada.Servicios
{
    internal class SolicitudImplementacion : SolicitudInterfaz
    {

        public int numero()
        {

            int numero;
            Console.WriteLine("Introduzca un número:");
            numero = int.Parse(Console.ReadLine());
            return numero;

        }
    }
}
