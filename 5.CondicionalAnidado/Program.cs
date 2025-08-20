namespace _5.CondicionalAnidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Diseñar un algoritmo que lea tres números A, B y C 
             * y visualice en pantalla el valor más grande. 
             * El usuario debe ingresar tres valores diferentes.
            */
            float num1 = 0;
            float num2 = 0;
            float num3 = 0;

            Console.WriteLine("Ingrese el primer número");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número");
            num3 = float.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"Número mayor: {num1}");
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine($"Número mayor: {num2}");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine($"Número mayor: {num3}");
            }

            /*Si el promedio se ubica en los siguientes rangos, escribir los correspondientes mensajes. 
             * Considerar la situación en donde el promedio generado no esté contemplado en los rangos establecidos, 
             * mostrar mensaje de error. 
             * 9.5-10.0 Excelente 
             * 8.5-9.4 Muy bien 
             * 7.5-8.4 Bien */

            float promedio = (num1 + num2 + num3) / 3f;

            if (promedio >= 9.5f)
            {
                Console.WriteLine($"Promedio:{promedio}, Excelente");
            }
            else if (promedio >= 8.5f && promedio <= 9.4f)
            {
                Console.WriteLine($"Promedio:{promedio}, Muy bien");
            }
            else if (promedio >= 7.5f && promedio <= 8.4)
            {
                Console.WriteLine($"Promedio:{promedio}, Bien");
            }
            else
            {
                Console.WriteLine($"Error, el promedio se encuentra por debajo o por encima de lo esperado");
            }
        }
    }
}

