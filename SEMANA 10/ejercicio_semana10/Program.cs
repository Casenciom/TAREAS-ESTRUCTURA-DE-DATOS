// Tarea semana 10  El Gobierno Nacional, a través del Ministerio de Salud, requiere información sobre la campaña de 
//vacunación contra el COVID-19.

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SISTEMA DE VACUNACIÓN COVID-19 ===\n");

        // Crear ciudadanos
        var todos = Enumerable.Range(1, 500)
                              .Select(i => $"Ciudadano {i}")
                              .ToHashSet();

        var random = new Random();
        var mezclados = todos.OrderBy(x => random.Next()).ToList();

        // Asignar vacunas 
        var pfizer = mezclados.Take(75).ToHashSet();
        var astra = mezclados.Skip(75).Take(75).ToHashSet();

        // Operaciones de conjuntos
        var ambas = pfizer.Intersect(astra).ToHashSet();
        var soloPfizer = pfizer.Except(astra).ToHashSet();
        var soloAstra = astra.Except(pfizer).ToHashSet();
        var noVacunados = todos.Except(pfizer.Union(astra)).ToHashSet();

        // Mostrar resultados
        Console.WriteLine($"Total ciudadanos: {todos.Count}");
        Console.WriteLine($"No vacunados: {noVacunados.Count}");
        Console.WriteLine($"Solo Pfizer: {soloPfizer.Count}");
        Console.WriteLine($"Solo AstraZeneca: {soloAstra.Count}");
        Console.WriteLine($"Ambas dosis: {ambas.Count}");

        // Verificación
        int total = noVacunados.Count + soloPfizer.Count + soloAstra.Count + ambas.Count;
        Console.WriteLine($"\nVerificación total: {total}");

        Console.WriteLine(total == 500 
            ? " Totales correctos" 
            : " Error en los cálculos");
    }
}