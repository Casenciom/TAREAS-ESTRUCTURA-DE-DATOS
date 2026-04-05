//PRACTICO 4 IMPLEMENTACIÓN Y REPRESENTACIÓN DE ÁRBOLES Y GRAFOS.

using System;
using System.Collections.Generic;

class Grafo
{
    private Dictionary<string, List<(string destino, int costo)>> adyacencia;

    public Grafo()
    {
        adyacencia = new Dictionary<string, List<(string, int)>>();
    }

    public void AgregarVuelo(string origen, string destino, int costo)
    {
        if (!adyacencia.ContainsKey(origen))
            adyacencia[origen] = new List<(string, int)>();

        if (!adyacencia.ContainsKey(destino))
            adyacencia[destino] = new List<(string, int)>();

        adyacencia[origen].Add((destino, costo));
    }

    //  REPORTERÍA 
    public void MostrarVuelos()
    {
        Console.WriteLine("\n=== REPORTE DE VUELOS ===");

        foreach (var ciudad in adyacencia)
        {
            // No mostrar ciudades sin vuelos salientes
            if (ciudad.Value.Count == 0)
                continue;

            Console.WriteLine($"\nDesde {ciudad.Key}:");

            foreach (var vuelo in ciudad.Value)
            {
                Console.WriteLine($" -> {vuelo.destino} | Costo: ${vuelo.costo}");
            }
        }
    }

    public void Dijkstra(string origen, string destino)
    {
        if (!adyacencia.ContainsKey(origen) || !adyacencia.ContainsKey(destino))
        {
            Console.WriteLine("\nCiudad no encontrada en el sistema.");
            return;
        }

        var distancias = new Dictionary<string, int>();
        var anteriores = new Dictionary<string, string?>();
        var visitados = new HashSet<string>();

        foreach (var nodo in adyacencia.Keys)
        {
            distancias[nodo] = int.MaxValue;
            anteriores[nodo] = null;
        }

        distancias[origen] = 0;

        while (visitados.Count < adyacencia.Count)
        {
            string? actual = null;
            int menorDistancia = int.MaxValue;

            foreach (var nodo in distancias)
            {
                if (!visitados.Contains(nodo.Key) && nodo.Value < menorDistancia)
                {
                    menorDistancia = nodo.Value;
                    actual = nodo.Key;
                }
            }

            if (actual == null)
                break;

            visitados.Add(actual);

            foreach (var vecino in adyacencia[actual])
            {
                int nuevaDistancia = distancias[actual] + vecino.costo;

                if (nuevaDistancia < distancias[vecino.destino])
                {
                    distancias[vecino.destino] = nuevaDistancia;
                    anteriores[vecino.destino] = actual;
                }
            }
        }

        if (distancias[destino] == int.MaxValue)
        {
            Console.WriteLine("\nNo existe ruta disponible.");
            return;
        }

        Console.WriteLine("\n=== RESULTADO ===");
        Console.WriteLine($"Costo mínimo: ${distancias[destino]}");

        List<string> ruta = new List<string>();
        string? temp = destino;

        while (temp != null)
        {
            ruta.Insert(0, temp);
            temp = anteriores[temp];
        }

        Console.WriteLine("Ruta: " + string.Join(" -> ", ruta));
    }
}

class Program
{
    static void Main()
    {
        Grafo grafo = new Grafo();

        // Base de datos
        grafo.AgregarVuelo("Quito", "Guayaquil", 50);
        grafo.AgregarVuelo("Quito", "Cuenca", 70);
        grafo.AgregarVuelo("Guayaquil", "Cuenca", 40);
        grafo.AgregarVuelo("Guayaquil", "Loja", 90);
        grafo.AgregarVuelo("Cuenca", "Loja", 30);
        grafo.AgregarVuelo("Loja", "Manta", 100);
        grafo.AgregarVuelo("Cuenca", "Manta", 120);

        int opcion = 0;

        do
        {
            Console.WriteLine("\n=== SISTEMA DE VUELOS BARATOS ===");
            Console.WriteLine("1. Ver vuelos disponibles");
            Console.WriteLine("2. Buscar vuelo más barato");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");

            string? input = Console.ReadLine();

            if (!int.TryParse(input, out opcion))
            {
                Console.WriteLine("Entrada inválida.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    grafo.MostrarVuelos();
                    break;

                case 2:
                    Console.Write("\nIngrese ciudad origen: ");
                    string? origen = Console.ReadLine();

                    Console.Write("Ingrese ciudad destino: ");
                    string? destino = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(origen) || string.IsNullOrWhiteSpace(destino))
                    {
                        Console.WriteLine("Datos inválidos.");
                        break;
                    }

                    grafo.Dijkstra(origen, destino);
                    break;

                case 3:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 3);
    }
}