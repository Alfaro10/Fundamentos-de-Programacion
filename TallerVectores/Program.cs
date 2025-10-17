namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector;
            vector = new int[15];
            int mayor = 0;
            int menor = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingrese el número entero para la posición {i + 1}, con índice {i}:");
                vector[i] = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    mayor = vector[i];
                    menor = vector[i];
                }
                else
                {
                    if (vector[i] > mayor)
                    {
                        mayor = vector[i];
                    }
                    if (vector[i] < menor)
                    {
                        menor = vector[i];
                    }
                    
                }
            
            }
            Console.Clear();

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + "|");
            }

            Console.WriteLine($"El número mayor es: {mayor}, el número menor es: {menor}");
        }
    }
}
