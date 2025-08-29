using System;

namespace ParcialProgramaciónIsabelAlfaro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un conjunto de personas ha sido clasificado en cuatro grupos denominados A, B, C y D, 
            en función de tres criterios: sexo, edad y el último dígito del documento de identidad. 
            La asignación a los grupos se realiza de acuerdo con las siguientes reglas: 
            Grupo A 
                Pertenecen al grupo A las personas que cumplan alguna de estas dos condiciones: 
                    Mujeres con edad entre 16 y 20 años, y cuyo documento de identidad termine en 0, 4 o 8. 
                    Hombres con edad entre 18 y 22 años, y cuyo documento de identidad termine en 1, 5 o 9. 
            Grupo B 
                Pertenecen al grupo B las personas que cumplan alguna de estas dos condiciones: 
                    Mujeres con edad entre 21 y 25 años, y cuyo documento de identidad termine en 3 o 7. 
                    Hombres con edad entre 23 y 26 años, y cuyo documento de identidad termine en 2 o 6. 
            Grupo C 
                Pertenecen al grupo C las personas (sin distinción de sexo) que tengan 15 años de edad y que dominen el idioma inglés. 
            Grupo D 
                Pertenecen al grupo D todas aquellas personas que no cumplen con ninguno de los criterios anteriores. */

            int edad;
            char sexo;
            int numero;
            char ingles;

            Console.WriteLine("Ingrese su edad:");
            edad = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su sexo, F (femenino), M (masculino):");
            sexo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Ingrese el último dígito de su documento de identidad:");
            numero = Int32.Parse(Console.ReadLine());

            if (edad == 15)
            {
                Console.WriteLine("¿Domina el inglés? (S si , N no):");
                ingles = Convert.ToChar(Console.ReadLine());

                if (ingles == 'S')
                {
                    Console.WriteLine("Pertenece al grupo C: 15 años y domina el idioma inglés.");
                }
                else
                {
                    Console.WriteLine("Pertenece al grupo D.");
                }
            }
            else
            {
                
                switch (sexo)
                {
                    case 'F': 
                        if (edad >= 16 && edad <= 20 && (numero == 0 || numero == 4 || numero == 8))
                        {
                            Console.WriteLine("Pertenece al grupo A, mujer entre 16 y 20 años, documento termina en 0, 4 o 8).");
                        }
                        else if (edad >= 21 && edad <= 25 && (numero == 3 || numero == 7))
                        {
                            Console.WriteLine("Pertenece al grupo B, mujer entre 21 y 25 años, documento termina en 3 o 7).");
                        }
                        else
                        {
                            Console.WriteLine("Pertenece al grupo D.");
                        }
                        break;

                    case 'M': 
                        if (edad >= 18 && edad <= 22 && (numero == 1 || numero == 5 || numero == 9))
                        {
                            Console.WriteLine("Pertenece al grupo A (hombre entre 18 y 22 años, documento termina en 1, 5 o 9).");
                        }
                        else if (edad >= 23 && edad <= 26 && (numero == 2 || numero == 6))
                        {
                            Console.WriteLine("Pertenece al grupo B (hombre entre 23 y 26 años, documento termina en 2 o 6).");
                        }
                        else
                        {
                            Console.WriteLine("Pertenece al grupo D.");
                        }
                        break;

                    default:
                        Console.WriteLine("Sexo inválido.");
                        break;
                }
            }
        }
    }
}
