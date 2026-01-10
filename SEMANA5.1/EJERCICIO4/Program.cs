// EJERCICIO 4 Escribir un programa que pregunte al usuario los 
//números ganadores de la lotería primitiva, los almacene en una lista y los muestre por pantalla ordenados de menor a mayor.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista para almacenar los números ganadores
        List<int> numeros = new List<int>();

        Console.WriteLine("Ingrese los números ganadores de la lotería primitiva:");

        // Pedir los números al usuario (6 números)
        for (int i = 1; i <= 6; i++)
        {
            Console.Write("Número " + i + ": ");
            int numero = int.Parse(Console.ReadLine());
            numeros.Add(numero);
        }

        // Ordenar la lista de menor a mayor
        numeros.Sort();

        Console.WriteLine("\nNúmeros ordenados de menor a mayor:");

        // Mostrar los números ordenados
        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }
    }
}

