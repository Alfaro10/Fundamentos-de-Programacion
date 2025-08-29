using System.Diagnostics.CodeAnalysis;

namespace _11.While3
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            /* Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se
             * ingrese un número negativo. Se debe mostrar en pntalla la suma de los números ingresados */
            int número = 0;
            int suma = 0;

            Console.WriteLine("Ingrese un número");
            número = Convert.ToInt32(Console.ReadLine());

            while (número > 0)
            {
                suma += número;

                Console.WriteLine("Ingrese el siguiente número (negativo para terminar)");
                número = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine($"Número negativo ingresado, la suma total es {suma}");
            
        }
    }
}
