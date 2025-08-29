namespace _10.While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita calcular la factorial de un número dado por el usuario.

            int número;
            int factorial = 1;
            int acumulador;

            Console.WriteLine("Ingrese un número para sacarle factorial");
            número = Convert.ToInt32(Console.ReadLine());

            acumulador = número;

            while(acumulador > 0) 
            {
                factorial *= acumulador;
                acumulador--;
            }

            Console.WriteLine($"Factorial de {número} = {factorial}");
        }
    }
}
