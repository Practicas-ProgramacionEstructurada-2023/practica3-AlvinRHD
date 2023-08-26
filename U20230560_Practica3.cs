using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

            //Declaracion de variables
            string? Marca_Zapato;
            string? Color_Zapato;
            int Cantidad;
            double Precio_Zapato;

            //Capturación de los datos
            Console.WriteLine("\n-------------Capturando Variables------------\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ingrese la marca de zapatos a comprar:");
            Marca_Zapato = Convert.ToString(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ingrese el color del par de zapatos:");
            Color_Zapato = Convert.ToString(Console.ReadLine());
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ingrese la cantidad de pares de zapatos a comprar");
            Cantidad = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ingrese el precio del par de zapatos a comprar:");
            Precio_Zapato = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("\n---------Fin de captura de variables---------\n");

            //Capturadno el total a pagar
            double Total = Cantidad * Precio_Zapato;

            //Imprimiendo resultados
            Console.WriteLine("\n-----------Imprimiendo resultados--------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nLa marca de zapatos a comprar es: " + Marca_Zapato);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nEL color de sus zapatos es: " + Color_Zapato);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nLa cantidad de pares de zapatos es: " + Cantidad);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nEL precio por par de zapatos a comprar es: $" + Precio_Zapato);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nEl total a pagar es: $" + Total);
            Console.ResetColor();
            Console.WriteLine("\n-----------Fin de imprimir resultados----------\n");
        }
    }
}