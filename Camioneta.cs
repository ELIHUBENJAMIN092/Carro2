using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro2
{
    class Camioneta : Vehiculo
    {
        private double capacidadCarga;

        public double CapacidadCarga
        {
            get { return capacidadCarga; }
            set
            {
                if (value > 0)
                    capacidadCarga = value;
                else
                    Console.WriteLine("Capacidad de carga no válida");
            }
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine($"Capacidad de carga: {CapacidadCarga} toneladas");
        }
    }
}