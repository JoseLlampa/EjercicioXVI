using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioXVI
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantDigitos = 1;
            int esNumero=0;
            string numeroIngresado;
            bool error = false;

            //Console.WriteLine("Ingrese un numero para calcular la cantidad de digitos");

            do
            {
                Console.WriteLine("Ingrese un numero para calcular la cantidad de digitos");//BORRAR
                numeroIngresado=Console.ReadLine();
                error = false;
                if (int.Parse(numeroIngresado) < 0)
                {
                    Console.WriteLine("Debe ingresar un numero entero positivo");
                    error = true;
                    Console.ReadKey();
                    Console.Clear();
                }
                if(!int.TryParse(numeroIngresado, out esNumero))
                {
                    Console.WriteLine("Debe ingresar un numero entero");
                    error = true;
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (error);

            int cantDigito = numeroIngresado.Length;
            Console.WriteLine("El numero "+numeroIngresado+"  tiene " + cantDigito + " digitos");
            /*for (int i=1;i<=numeroIngresado.Length; i++)
                {
                    
                }*/
            Console.ReadKey();
        }
    }
}
