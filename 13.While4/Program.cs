namespace _13.While4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar.
             * Al usuario le corresponde ingresar la cantidad de números que va a introducir. 
             * El algoritmo debe escribir en pantalla:
             *  La cantidad de números introducidos que son mayores que 0
             *  La cantidad de números introducidos menores que 0
             *  La cantidad de números iguales a 0 */

            int cantidad = 0;
            Console.WriteLine("Cuántos números va a introducir?");
            cantidad = Convert.ToInt32(Console.ReadLine());
            int numero = 0;
            int mayores = 0;
            int menores = 0;
            int iguales = 0;

            while(cantidad > 0 )
            {
                Console.WriteLine("Ingrese un número");
                numero = Convert.ToInt32(Console.ReadLine());

                if( numero == 0)
                {
                    iguales++;
                }
                else if ( numero < 0)
                {
                    menores ++;
                }
                else if ( numero > 0 )
                {
                    mayores++;
                }
                cantidad--;

            }
            Console.WriteLine($"Números mayores que 0: {mayores}. Iguales a 0: {iguales}. Menores que 0: {menores}");

        }
    }
}
