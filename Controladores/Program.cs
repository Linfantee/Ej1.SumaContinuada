using Ej1.SumaContinuada.Servicios;

namespace Ej1.SumaContinuada
{
    class Program
    {

        static void Main(string[] args)
        {

            SolicitudInterfaz aka = new SolicitudImplementacion();
            int numero;
            numero = aka.numero();

            SolicitudInterfaz2 ao = new SolicitudImplementacion2();
            ao.suma(numero);




        }




    }





}