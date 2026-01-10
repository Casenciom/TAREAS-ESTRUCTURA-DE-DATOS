// EJERCICIO 3 Escribir un programa que almacene las asignaturas de un curso 
//en una lista, pregunte al usuario la nota que ha sacado en cada asignatura, y después las muestre por pantalla con el mensaje 
//En <asignatura> has sacado <nota> donde <asignatura> es cada una des las asignaturas de la lista y <nota> cada una 
//de las correspondientes notas introducidas por el usuario.


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista de asignaturas
        List<string> asignaturas = new List<string>
        {
            "Estructura de Datos",
            "Fundamentos de Sistemas Digitales",
            "Instalaciones Electricas",
            "Metodologia de la Investigacion",
            "Admin de sistemas operativos"
        };

        // Lista para almacenar las notas
        List<double> notas = new List<double>();

        // Pedir la nota de cada asignatura
        foreach (string asignatura in asignaturas)
        {
            Console.Write("Ingresa la nota de " + asignatura + ": ");
            double nota = double.Parse(Console.ReadLine());
            notas.Add(nota);
        }

        Console.WriteLine("\nResultados:");

        // Mostrar asignaturas con sus notas
        for (int i = 0; i < asignaturas.Count; i++)
        {
            Console.WriteLine("En " + asignaturas[i] + " has sacado " + notas[i]);
        }
    }
}

