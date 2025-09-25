// Se desea guardar los sueldos de 5 operarios.
using System;

namespace cinco_sueldos_array
{
    class cinco_sueldos_array
    {
        private int[] sueldos;

        public void Cargar()
        {
            sueldos = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese el sueldo {i+1}: ");
                sueldos[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine($"Sueldo {f + 1} es {sueldos[f]}");
            }

            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            cinco_sueldos_array pv = new cinco_sueldos_array();
            pv.Cargar();
            pv.Imprimir();
        }


    }
}