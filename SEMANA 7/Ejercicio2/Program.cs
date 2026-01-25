//Ejercicio 2 Resolución del problema de las Torres de Hanoi

using System;
using System.Collections.Generic;

class TorresDeHanoi
{
    static Stack<int> origen = new Stack<int>();
    static Stack<int> auxiliar = new Stack<int>();
    static Stack<int> destino = new Stack<int>();

    static void Main()
    {
        int n = 3; // Número de discos

        // Inicializar torre origen
        for (int i = n; i >= 1; i--)
        {
            origen.Push(i);
        }

        ResolverHanoi(n, origen, destino, auxiliar);

        Console.ReadLine();
    }

    static void ResolverHanoi(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar)
    {
        if (n == 1)
        {
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} del ORIGEN al DESTINO");
            return;
        }

        ResolverHanoi(n - 1, origen, auxiliar, destino);

        int d = origen.Pop();
        destino.Push(d);
        Console.WriteLine($"Mover disco {d} del ORIGEN al DESTINO");

        ResolverHanoi(n - 1, auxiliar, destino, origen);
    }
}
