// See https://aka.ms/new-console-template for more information


using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese cuatro números
        Console.WriteLine("Ingrese el primer número:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer número:");
        double num3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el cuarto número:");
        double num4 = Convert.ToDouble(Console.ReadLine());

        // Calcular la suma de los cuatro números
        double suma = num1 + num2 + num3 + num4;

        // Calcular el promedio de los cuatro números
        double promedio = suma / 4;

        // Mostrar los resultados
        Console.WriteLine($"La suma de los cuatro números es: {suma}");
        Console.WriteLine($"El promedio de los cuatro números es: {promedio}");
    }
}
