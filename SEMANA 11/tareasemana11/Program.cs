//Tarea semana 11 Desarrollar una aplicación en C# que funcione como un traductor básico entre los idiomas inglés y español, 
//utilizando diccionarios como estructura principal para almacenar las palabras y sus equivalencias.

using System;
using System.Collections.Generic;
using System.Text;

class Traductor
{
    static void Main()
    {
        // Diccionario Español - Inglés
        Dictionary<string, string> diccionario = new(StringComparer.OrdinalIgnoreCase)
        {
            {"tiempo", "time"},
            {"persona", "person"},
            {"año", "year"},
            {"dia", "day"},
            {"cosa", "thing"},
            {"mundo", "world"},
            {"vida", "life"},
            {"mano", "hand"},
            {"ojo", "eye"},
            {"trabajo", "work"}
        };

        int opcion;

        do
        {
            Console.WriteLine("\n========== MENÚ ==========");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabra");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Traducir(diccionario);
                    break;

                case 2:
                    Agregar(diccionario);
                    break;

                case 0:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }

    // Método para traducir frases
    static void Traducir(Dictionary<string, string> dic)
    {
        Console.Write("\nIngrese una frase: ");
        string? frase = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(frase))
        {
            Console.WriteLine("Entrada vacía.");
            return;
        }

        string[] palabras = frase.Split(' ');
        StringBuilder resultado = new();

        foreach (string palabra in palabras)
        {
            string limpia = palabra.Trim(',', '.', ';', ':', '¡', '!', '¿', '?');

            if (dic.TryGetValue(limpia, out string? traduccion))
                resultado.Append(traduccion + " ");
            else
                resultado.Append(palabra + " ");
        }

        Console.WriteLine("\nTraducción parcial:");
        Console.WriteLine(resultado.ToString().Trim());
    }

    // Método para agregar palabras
    static void Agregar(Dictionary<string, string> dic)
    {
        Console.Write("\nPalabra en español: ");
        string? esp = Console.ReadLine();

        Console.Write("Traducción en inglés: ");
        string? ing = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(esp) || string.IsNullOrWhiteSpace(ing))
        {
            Console.WriteLine("Datos inválidos.");
            return;
        }

        if (dic.ContainsKey(esp))
            Console.WriteLine("La palabra ya existe.");
        else
        {
            dic.Add(esp, ing);
            Console.WriteLine("Palabra agregada correctamente.");
        }
    }
}