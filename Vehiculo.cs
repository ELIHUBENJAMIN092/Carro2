using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro2
{
    class Vehiculo
    {
        private string marca;
        private string modelo;
        private int año;

        public string Marca
        {
            get { return marca; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    marca = value;
                else
                    Console.WriteLine("Marca no válida");
            }
        }
        public string Modelo
        {
            get { return modelo; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    modelo = value;
                else
                    Console.WriteLine("Modelo no válido");
            }
        }

        public int Año
        {
            get { return año; }
            set
            {
                if (value > 0)
                    año = value;
                else
                    Console.WriteLine("Año no válido");
            }
        }

        public virtual void GetInformation()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Año}");
        }

        public virtual void RunAction()
        {
            Console.WriteLine("Realizando una acción genérica del vehículo");
        }
    }
}
