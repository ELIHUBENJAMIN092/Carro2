using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro2
{
    class Automovil : Vehiculo
    {
        private int puertas;

        public int Puertas
        {
            get { return puertas; }
            set
            {
                if (value > 0)
                    puertas = value;
                else
                    Console.WriteLine("Número de puertas no válido");
            }
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine($"Puertas: {Puertas}");
        }
    }
}