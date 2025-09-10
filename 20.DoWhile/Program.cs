namespace _20.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un equipo de futbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber:   
            El número de partidos perdidos  
            El número de partidos empatados  
            El número de partidos ganados  
            El porcentaje de partidos perdidos  
            El porcentaje de partidos empatados  
            El porcentaje de partidos ganados */

            int ganados = 0;
            int perdidos = 0;
            int empatados = 0;
            int jugados = 0;
            int total = 30;
            do
            {
                Console.WriteLine("Ingrese el resultado del partido (G: Ganado, P: Perdido, E: Empatado): ");
                string resultado = Console.ReadLine().ToUpper();
                switch (resultado)
                {
                    case "G":
                        ganados++;
                        break;
                    case "P":
                        perdidos++;
                        break;
                    case "E":
                        empatados++;
                        break;

                }
                jugados++;

            } while (jugados < total);

            Console.WriteLine($"Total de partidos jugados: {total}");

            Console.WriteLine($"Partidos Ganados: {ganados} ({(ganados * 100) / total}%)");

            Console.WriteLine($"Partidos Empatados: {empatados} ({(empatados * 100) / total}%)");

            Console.WriteLine($"Partidos Perdidos: {perdidos} ({(perdidos * 100) / total}%)");


        }
    }
}