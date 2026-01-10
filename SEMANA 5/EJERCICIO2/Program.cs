// Escribir un programa que almacene las asignaturas de un curso en una lista y la muestre por pantalla el mensaje Yo estudio <asignatura>, donde <asignatura> es cada una de las asignaturas de la lista.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista de asignaturas
        List<string> asignaturas = new List<string>
        {
            "Admin de sistemas operativos",
            "Metodologia de la Investigacion",
            "Instalaciones Electricas",
            "Fundamentos de Sistemas Digitales",
            "Estructura de Datos"
        };

        // Mostrar el mensaje para cada asignatura
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine("Yo estudio " + asignatura);
        }
    }
}
