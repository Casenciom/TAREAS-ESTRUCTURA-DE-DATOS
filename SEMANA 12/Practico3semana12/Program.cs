//PRACTICO 3 Aplicación para el registro de jugadores y equipos en un torneo de futbol.

using System;
using System.Collections.Generic;

class TorneoFutbol
{
    static Dictionary<string, HashSet<string>> equipos = new Dictionary<string, HashSet<string>>();

    static void Main()
    {
        int opcion = 0;

        do
        {
            Console.WriteLine("\n=== TORNEO DE FUTBOL ===");
            Console.WriteLine("1. Registrar equipo");
            Console.WriteLine("2. Registrar jugador en equipo");
            Console.WriteLine("3. Ver equipos registrados");
            Console.WriteLine("4. Ver jugadores de un equipo");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opcion: ");

            string? entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcion))
            {
                Console.WriteLine("Ingrese un numero valido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    RegistrarEquipo();
                    break;

                case 2:
                    RegistrarJugador();
                    break;

                case 3:
                    MostrarEquipos();
                    break;

                case 4:
                    MostrarJugadores();
                    break;

                case 5:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }

        } while (opcion != 5);
    }

    static void RegistrarEquipo()
    {
        Console.Write("Ingrese nombre del equipo: ");
        string? equipo = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(equipo))
        {
            Console.WriteLine("Nombre invalido.");
            return;
        }

        if (!equipos.ContainsKey(equipo))
        {
            equipos[equipo] = new HashSet<string>();
            Console.WriteLine("Equipo registrado correctamente.");
        }
        else
        {
            Console.WriteLine("El equipo ya existe.");
        }
    }

    static void RegistrarJugador()
    {
        Console.Write("Ingrese nombre del equipo: ");
        string? equipo = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(equipo) || !equipos.ContainsKey(equipo))
        {
            Console.WriteLine("El equipo no existe.");
            return;
        }

        Console.Write("Ingrese nombre del jugador: ");
        string? jugador = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(jugador))
        {
            Console.WriteLine("Nombre invalido.");
            return;
        }

        if (equipos[equipo].Add(jugador))
        {
            Console.WriteLine("Jugador registrado correctamente.");
        }
        else
        {
            Console.WriteLine("El jugador ya existe en el equipo.");
        }
    }

    static void MostrarEquipos()
    {
        if (equipos.Count == 0)
        {
            Console.WriteLine("No hay equipos registrados.");
            return;
        }

        Console.WriteLine("\nEquipos registrados:");

        foreach (var equipo in equipos.Keys)
        {
            Console.WriteLine("- " + equipo);
        }
    }

    static void MostrarJugadores()
    {
        Console.Write("Ingrese nombre del equipo: ");
        string? equipo = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(equipo) || !equipos.ContainsKey(equipo))
        {
            Console.WriteLine("Equipo no encontrado.");
            return;
        }

        Console.WriteLine("Jugadores del equipo " + equipo + ":");

        foreach (var jugador in equipos[equipo])
        {
            Console.WriteLine("- " + jugador);
        }
    }
}