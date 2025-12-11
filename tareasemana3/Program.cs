//TAREA SEMANA 3 ARRAYS Y MATRICES
using System;

class Estudiante
{
    // Propiedades
    public int ID { get; set; }
    public string Nombres { get; set; } = "";
    public string Apellidos { get; set; } = "";
    public string Direccion { get; set; } = "";
    public string[] Telefonos { get; set; }

    // Constructor
    public Estudiante()
    {
        Telefonos = new string[3]; // Array de 3 teléfonos 
    }

    // Método para mostrar información
    public void MostrarInformacion()
    {
        Console.WriteLine("\n===== DATOS DEL ESTUDIANTE =====");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine("Teléfonos:");

        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Estudiante estudiante = new Estudiante();

        Console.WriteLine("**** REGISTRO DE ESTUDIANTE ****\n");

        Console.Write("Ingrese el ID: ");
        estudiante.ID = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Ingrese los nombres: ");
        estudiante.Nombres = Console.ReadLine() ?? "";

        Console.Write("Ingrese los apellidos: ");
        estudiante.Apellidos = Console.ReadLine() ?? "";

        Console.Write("Ingrese la dirección: ");
        estudiante.Direccion = Console.ReadLine() ?? "";

        Console.WriteLine("\nIngrese los 3 números de teléfono:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Teléfono {i + 1}: ");
            estudiante.Telefonos[i] = Console.ReadLine() ?? "";
        }

        // Mostrar información final
        estudiante.MostrarInformacion();

        Console.WriteLine("\nPresione una tecla para finalizar...");
        Console.ReadKey();
    }
}
