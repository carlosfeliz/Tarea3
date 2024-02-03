// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número positivo de uno o dos dígitos (1..99):");

        // Leer la entrada del usuario
        string input = Console.ReadLine();

        // Intentar convertir la entrada a un número entero
        if (int.TryParse(input, out int numero))
        {
            // Verificar si el número tiene uno o dos dígitos
            if (numero >= 1 && numero <= 9)
            {
                Console.WriteLine("El número tiene un dígito.");
            }
            else if (numero >= 10 && numero <= 99)
            {
                Console.WriteLine("El número tiene dos dígitos.");
            }
            else
            {
                Console.WriteLine("El número no está en el rango válido.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero positivo.");
        }
    }
}

