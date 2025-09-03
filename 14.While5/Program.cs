namespace _14.While5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un algoritmo que cuente cuántos números pares hay en un rango de números del 1 al número n.

            int cantidadPares = 0;
            int n = 0;
            int contador = 1;

            Console.WriteLine("Ingrese un número n");
            n = Convert.ToInt32(Console.ReadLine());

            while (contador <= n)
            {
                if(contador % 2 == 0)
                {
                    cantidadPares++;
                }

                contador++;
            }
            Console.WriteLine($"Hay {cantidadPares} números pares en el rango del 1 al {n}");
        }
    }
}
