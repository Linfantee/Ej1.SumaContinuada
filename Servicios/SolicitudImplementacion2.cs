using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.SumaContinuada.Servicios
{
    internal class SolicitudImplementacion2 : SolicitudInterfaz2
    {
        public void suma(int k) 
        {
            int almacenamiento = 0;
      
            for (int i = 1; i <= k; i++)
            {
                almacenamiento += i;
            }
                Console.WriteLine("El resultado del número elegido es:" + almacenamiento);
            
        }
    }
}
