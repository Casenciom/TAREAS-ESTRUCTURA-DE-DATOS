using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Lista principal
        List<double> datos = new List<double>();

        // Llamar a la función para cargar datos
        CargarDatos(datos);

        // Calcular promedio
        double promedio = CalcularPromedio(datos);

        // Listas para clasificar
        List<double> menoresIguales = new List<double>();
        List<double> mayores = new List<double>();

        // Clasificar datos
        ClasificarDatos(datos, promedio, menoresIguales, mayores);

        // Mostrar resultados
        MostrarResultados(datos, promedio, menoresIguales, mayores);
    }

    // Función para cargar los datos
    static void CargarDatos(List<double> datos)
    {
        Console.Write("Ingrese la cantidad de datos: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Ingrese un dato: ");
            double valor = double.Parse(Console.ReadLine());
            datos.Add(valor);
        }
    }

    // Función para calcular el promedio
    static double CalcularPromedio(List<double> datos)
    {
        double suma = 0;

        for (int i = 0; i < datos.Count; i++)
        {
            suma = suma + datos[i];
        }

        return suma / datos.Count;
    }

    // Función para clasificar los datos
    static void ClasificarDatos(List<double> datos, double promedio,
                                List<double> menoresIguales, List<double> mayores)
    {
        for (int i = 0; i < datos.Count; i++)
        {
            if (datos[i] <= promedio)
            {
                menoresIguales.Add(datos[i]);
            }
            else
            {
                mayores.Add(datos[i]);
            }
        }
    }

    // Función para mostrar resultados
    static void MostrarResultados(List<double> datos, double promedio,
                                  List<double> menoresIguales, List<double> mayores)
    {
        Console.WriteLine("\nDatos de la lista principal:");
        MostrarLista(datos);

        Console.WriteLine("\nPromedio:");
        Console.WriteLine(promedio);

        Console.WriteLine("\nDatos menores o iguales al promedio:");
        MostrarLista(menoresIguales);

        Console.WriteLine("\nDatos mayores al promedio:");
        MostrarLista(mayores);
    }

    // Función para mostrar una lista
    static void MostrarLista(List<double> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            Console.Write(lista[i] + " ");
        }
        Console.WriteLine();
    }
}
