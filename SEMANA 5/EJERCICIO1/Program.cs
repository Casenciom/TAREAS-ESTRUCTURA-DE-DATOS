// Escribir un programa que almacene las asignaturas de un curso de la UEA en una lista y la muestre por pantalla.

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

        // Mostrar las asignaturas por pantalla
        Console.WriteLine("Las asignaturas del curso son de 3 semestre de TI:");
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine(asignatura);
        }
    }
}
