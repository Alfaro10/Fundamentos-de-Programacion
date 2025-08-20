using System.Security.Cryptography;

namespace _6.CondicionalMultipleTerciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*float valorCompra = 0;
            float descuento = 0;
            char día = ' ';

            Console.WriteLine("Ingrese el valor de la compra");
            valorCompra = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el día de la semana: l:Lunes, m:Martes, x:Miércoles, j:Jueves, v:Viernes, s:Sábado, d:Domingo");
            día = Convert.ToChar(Console.ReadLine());

            switch (día)
            {
                case 'l':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es lunes, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                case 'm':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es martes, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                case 'x':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es miércoles, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                case 'j':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es jueves, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                case 'v':
                    descuento = valorCompra * 0.20f;
                    Console.WriteLine($"Hoy es viernes, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                case 's':
                    descuento = valorCompra * 0.20f;
                    Console.WriteLine($"Hoy es sábado, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                case 'd':
                    descuento = valorCompra * 0.0f;
                    Console.WriteLine($"Hoy es domingo, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                default:
                    Console.WriteLine("Debe ingresar un valor válido.");
                    break;*/

            /*Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas 
             * entre dos números ingresados por el usuario. Las operaciones disponibles serán: suma, resta, multiplicación y división, 
             * las cuales se ejecutarán según la opción seleccionada por el usuario.*/

            /*float num1 = 0.0f;
            float num2 = 0.0f;
            char operación = ' ';
            float resultado = 0.0f;

            Console.WriteLine("Ingresa el primer número para ser operado");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo número para ser operado");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la operación que deseas hacer, s: suma, r: resta, m: multiplicación, d: división");
            operación = Convert.ToChar(Console.ReadLine());

            switch (operación)
            {
                case 's':
                    resultado = num1 + num2;
                    Console.WriteLine($"{num1} sumado {num2} es igual {resultado}");
                    break;
                case 'r':
                    resultado = num1 - num2;
                    Console.WriteLine($"{num1} restado {num2} es igual {resultado}");
                    break;
                case 'm':
                    resultado = num1 * num2;
                    Console.WriteLine($"{num1} mmultiplicado {num2} es igual {resultado}");
                    break;
                case 'd':
                    resultado = num1 / num2;
                    Console.WriteLine($"{num1} dividido {num2} es igual {resultado}");
                    break;
                default:
                    Console.WriteLine($"Syntax Error");
                    break;*/

            /*Diseñar un algoritmo que solicite al usuario un número del 1 al 12, 
             * correspondiente a un mes del año (1 para enero, 2 para febrero, etc.). 
             * El algoritmo debe mostrar en pantalla el nombre del mes seleccionado y la cantidad de días que contiene.*/

            int mes = 0;

            Console.WriteLine("Ingrese un número del 1 al 12");
            mes = Convert.ToInt32 (Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine($"Mes: Enero, tiene 31 días");
                    break;
                case 2:
                    Console.WriteLine($"Mes: Febrero, tiene 28 días (a menos que sea bisiesto");
                    break;
                case 3:
                    Console.WriteLine($"Mes: Marzo, tiene 31 días");
                    break;
                case 4:
                    Console.WriteLine($"Mes: Abril, tiene 30 días");
                    break;
                case 5:
                    Console.WriteLine($"Mes: Mayo, tiene 31 días");
                    break;
                case 6:
                    Console.WriteLine($"Mes: Junio, tiene 30 días");
                    break;
                case 7:
                    Console.WriteLine($"Mes: Julio, tiene 31 días");
                    break;
                case 8:
                    Console.WriteLine($"Mes: Agosto, tiene 31 días");
                    break;
                case 9:
                    Console.WriteLine($"Mes: Septiembre, tiene 30 días");
                    break;
                case 10:
                    Console.WriteLine($"Mes: Octubre, tiene 31 días");
                    break;
                case 11:
                    Console.WriteLine($"Mes: Noviembre, tiene 30 días");
                    break;
                case 12:
                    Console.WriteLine($"Mes: Diciembre, tiene 31 días");
                    break;
                default:
                    Console.WriteLine("Ingresa un mes válido :(");
                    break;

                }
            }
    }
}
