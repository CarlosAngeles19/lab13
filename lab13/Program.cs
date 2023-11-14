using System;

namespace lab13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                opcion = Pantallas.PantallaPrincipal();

                switch (opcion)
                {
                    case 1:
                        Pantallas.Satisfaccion();
                        break;
                    case 2:
                        Pantallas.VerDatosRegistrados();
                        break;
                    case 3:
                        Pantallas.EliminarDato();
                        break;
                    case 4:
                        // Agrega aquí la lógica para ordenar datos de menor a mayor
                        //Aca no llego explicar y dijo que no lo hicieramos.
                        break;
                    case 5:
                        break;
                }
            } while (opcion != 5);
        }
    }
}


