namespace _19.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            int genero = 0;
            int mayorEdad = 0;
            int menorEdad = 0;
            int hombres = 0;
            int mujeres = 0;
            int numeroEstudiantes = 0;
            int cantidad = 5;

            do
            {
                Console.WriteLine("Por favor, ingrese la edad:");
                edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Cuál es su género");
                Console.WriteLine("1.Hombre 2.Mujer");
                genero = int.Parse(Console.ReadLine());

                if (edad >= 18)
                {
                    mayorEdad++;
                }
                else
                {
                    menorEdad++;
                }

                if (genero == 1)
                {
                    hombres++;
                }
                else
                {
                    mujeres++;
                }
                numeroEstudiantes++;
            } while (numeroEstudiantes < cantidad);

            Console.WriteLine($"De los {cantidad} estudiantes, {mayorEdad} son mayores de edad, {menorEdad} son menores de edad, {hombres} son hombres, {mujeres} son mujeres");
        }
    }
}
