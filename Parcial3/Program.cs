using System.Security.Cryptography.X509Certificates;

namespace Parcial3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Análisis numérico de una matriz dinámica
            Implemente un programa que permita a un usuario definir, llenar y analizar una matriz de números enteros, 
            con el objetivo de obtener estadísticas numéricas específicas.
            Requisitos del programa:
            Definición de la matriz:
            Solicite al usuario ingresar el número de filas n y columnas m de la matriz.
            Ambos valores deben ser enteros mayores o iguales a 2 y menores o iguales a 10.
            Si el usuario ingresa valores fuera del rango, debe mostrarse un mensaje de error y volver a solicitar la entrada.
            Ingreso de elementos:
            Permita al usuario ingresar los elementos de la matriz manualmente, uno a uno, indicando la posición actual (fila, columna).
            Cada número debe ser un entero que puede ser positivo, negativo o cero.
            Visualización de la matriz:
            Una vez completado el ingreso, mostrar la matriz en pantalla con un formato tabular.
            Procesamiento y estadísticas:
            Calcular y mostrar en pantalla lo siguiente:
            La suma de todos los números pares ingresados en la matriz.
            La suma de todos los números impares.
            La cantidad de números negativos encontrados en la matriz.
            La cantidad total de ceros.
            El promedio general de todos los valores ingresados.
            Formato de salida:
            Cada resultado debe mostrarse con un mensaje descriptivo.
            Consideraciones técnicas:
            El cálculo del promedio debe considerar todos los elementos de la matriz. */

            int n = 0;
            int m = 0;

            do
            {
                Console.Write("Ingrese el número de filas n:");
                n = int.Parse(Console.ReadLine());
                if (n < 2 || n > 10)
                {
                    Console.WriteLine("Error: El número de filas debe estar entre 2 y 10. Ingrese un valor válido.");
                }
            } while (n < 2 || n > 10);

            do
            {
                Console.Write("Ingrese el número de columnas m: ");
                m = int.Parse(Console.ReadLine());
                if (m < 2 || m > 10)
                {
                    Console.WriteLine("Error: El número de columnas debe estar entre 2 y 10. Ingrese un valor válido.");
                }
            } while (m < 2 || m > 10);

            
            int[,] matriz = new int[n, m];

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Ingrese el valor para la posición [{i},{j}]: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            
            Console.WriteLine("Matriz:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + "|");
                }
                Console.WriteLine();
            }

            int sumaPares = 0;
            int sumaImpares = 0;
            int negativos = 0;
            int ceros = 0;
            int totalElementos = n * m;
            int sumaTotal = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int valor = matriz[i, j];
                    sumaTotal += valor;

                    if (valor % 2 == 0)
                    {
                        sumaPares += valor;
                    }
                    else
                    {
                        sumaImpares += valor;
                    }

                    if (valor < 0)
                    {
                        negativos++;
                    }

                    if (valor == 0)
                    {
                        ceros++;
                    }
                }
            }

            float promedio = (float)sumaTotal / totalElementos;

            Console.WriteLine($"Resultados: Suma de números pares: {sumaPares}, " +
                $"Suma de números impares: {sumaImpares}, " +
                $"Cantidad de números negativos: {negativos}, " +
                $"Cantidad de ceros: {ceros}, " +
                $"Promedio general de todos los valores: {promedio}");
            
        }
    }
}

