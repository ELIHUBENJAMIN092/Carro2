using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro2
{
    class Program
    {
        static void Main()
        {
            Automovil miAutomovil = new Automovil();
            miAutomovil.Marca = "Volkswagen";
            miAutomovil.Modelo = "Gol";
            miAutomovil.Año = 2024;
            miAutomovil.Puertas = 4;

            Camioneta miCamioneta = new Camioneta();
            miCamioneta.Marca = "Chevrolet";
            miCamioneta.Modelo = "Dimax";
            miCamioneta.Año = 2017;
            miCamioneta.CapacidadCarga = 6;

            Console.WriteLine("Información del Automóvil:");
            miAutomovil.GetInformation();
            Console.WriteLine("\nInformación de la Camioneta:");
            miCamioneta.GetInformation();

            Console.WriteLine("\nAcciones:");
            miAutomovil.RunAction();  // Acción genérica del automóvil
            miCamioneta.RunAction();  // Acción genérica de la camioneta
        }
    }
}
