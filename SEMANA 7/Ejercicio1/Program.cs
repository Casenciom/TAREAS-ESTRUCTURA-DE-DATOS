//Ejercicio 1 Verificación de paréntesis balanceados en una expresión matemática

using System;
using System.Collections.Generic;

class ParentesisBalanceados
{
    static void Main()
    {
        string expresion = "{7 + (4 * 5) - [(10 - 7) + (4 + 2)]}";

        if (EstaBalanceada(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula NO balanceada.");
    }

    static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            // Si es símbolo de apertura, se apila
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            // Si es símbolo de cierre
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0)
                    return false;

                char tope = pila.Pop();

                if (!Coinciden(tope, c))
                    return false;
            }
        }

        // Si la pila está vacía, está balanceada
        return pila.Count == 0;
    }

    static bool Coinciden(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '{' && cierre == '}') ||
               (apertura == '[' && cierre == ']');
    }
}
