using System;

namespace Parcial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se requiere diseñar un programa que calcule la nota final de un grupo de 10 alumnos a partir de sus evaluaciones. La calificación final se obtiene aplicando los siguientes porcentajes:
            Práctica: 10%
            Problemas: 50%
            Teórica: 40%
            Las notas de cada evaluación estarán en un rango de 0 a 10.
            El programa debe realizar, para cada alumno, las siguientes acciones:
            Solicitar el nombre del alumno.
            Ingresar las tres calificaciones correspondientes a práctica, problemas y teórica.
            Calcular la nota final ponderada según los porcentajes establecidos.
            Determinar si el alumno aprueba (nota final > 6) o reprueba (nota final ≤ 6).
            Mostrar en pantalla el nombre del alumno, la nota final y el resultado (aprobado o reprobado). */

            string nombre;
            float notapractica = 0;
            float notaproblemas = 0;
            float notateorica = 0;
            float notafinal = 0;
            bool aprobado = false;

            for (int i = 1; i <= 10; i++)
            {
                
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese su nota en Práctica (10%)");
                notapractica = float.Parse(Console.ReadLine());
                while (notapractica < 0 || notapractica > 10)
                {
                    Console.WriteLine("Ingrese un valor válido (entre 0 y 10)");
                    Console.Write("Ingrese su nota en Práctica (10%): ");
                    notapractica = float.Parse(Console.ReadLine());
                }

                Console.WriteLine("Ingrese su nota en Problemas (50%)");
                notaproblemas = float.Parse(Console.ReadLine());
                while (notaproblemas < 0 || notaproblemas > 10)
                {
                    Console.WriteLine("Ingrese un valor válido (entre 0 y 10)");
                    Console.Write("Ingrese su nota en Problemas (50%): ");
                    notaproblemas = float.Parse(Console.ReadLine());
                }

                Console.WriteLine("Ingrese su nota en Teórica (40%)");
                notateorica = float.Parse(Console.ReadLine());
                while (notateorica < 0 || notateorica > 10)
                {
                    Console.WriteLine("Ingrese un valor válido (entre 0 y 10)");
                    Console.Write("Ingrese su nota en Teórica (40%): ");
                    notateorica = float.Parse(Console.ReadLine());
                }

                    notafinal = (notapractica * 0.10f) + (notaproblemas * 0.50f) + (notateorica * 0.40f);

                if (notafinal > 6)
                {
                    Console.WriteLine($"{nombre}, su nota final es {notafinal} y ha aprobado con una nota mayor a 6.");
                }
                else
                {
                    Console.WriteLine($"{nombre}, su nota final es {notafinal} y ha reprobado con una nota menor o igual a 6.");
                }

            }    
        }
    }
}
