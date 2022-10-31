using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Carro
    {

        internal Carro(): this("Marca por defecto")
        {
            Console.WriteLine("Instanciando carro");
        }

        internal Carro(string marca) 
        {
            Console.WriteLine("Instanciando carro con marca");
            _marca = marca;
            ContadorInstancias++;
        }

        //Por convencion los campos empiezan con guin bajo
        private string _marca;
        //private int _año;
        /*Esto se puede siomplificar borrando y haciendolo como se ve más adelante. 
        
          Esto se hace cuando el campo o propiedad solo recibe y devuelve un valor
          
         */


        //Propiedades
        internal string Marca 
        {
            get { return _marca.ToUpper(); }
            set { _marca = value; }
        }

        //Campo y propiedad simplificados
        internal int Año { get; set; } = 1990; //Valor por defecto

        internal int Velocidad { get; private set; } = 25;
        private int VelocidaMaxima => 120;
        internal string NombreComercial => $"{Marca} ({Año})";


        internal void Acelerar()
        {
            ContadorInstancias++;
            Acelerar(1);
        }

        public static int ContadorInstancias { get; set; }

        internal void Acelerar(int incremento)
        {
            if (Velocidad >= VelocidaMaxima)
            {
                Console.WriteLine("Velocidad máxima alcanzada");
                return;
            }
            else if (Velocidad + incremento > VelocidaMaxima)
            {
                incremento = VelocidaMaxima - Velocidad;
            }

            Velocidad += incremento;
        }

        internal void Detener() => Velocidad = 0;



    }
}
