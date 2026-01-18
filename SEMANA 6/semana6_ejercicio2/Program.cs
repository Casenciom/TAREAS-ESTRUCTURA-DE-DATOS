using System;

class Nodo
{
    public int dato;
    public Nodo sig;

    public Nodo(int d)
    {
        dato = d;
        sig = null;
    }
}

class Lista
{
    Nodo inicio;

    public void Agregar(int d)
    {
        Nodo nuevo = new Nodo(d);

        if (inicio == null)
        {
            inicio = nuevo;
        }
        else
        {
            Nodo aux = inicio;
            while (aux.sig != null)
                aux = aux.sig;

            aux.sig = nuevo;
        }
    }

    public void Invertir()
    {
        Nodo ant = null;
        Nodo act = inicio;

        while (act != null)
        {
            Nodo sig = act.sig;
            act.sig = ant;
            ant = act;
            act = sig;
        }

        inicio = ant;
    }

    public void Mostrar()
    {
        Nodo aux = inicio;
        while (aux != null)
        {
            Console.Write(aux.dato + " ");
            aux = aux.sig;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Lista l = new Lista();

        l.Agregar(15);
        l.Agregar(20);
        l.Agregar(25);
        l.Agregar(30);
        l.Agregar(35);
        l.Agregar(40);

        Console.WriteLine("Lista original:");
        l.Mostrar();

        l.Invertir();

        Console.WriteLine("Lista invertida:");
        l.Mostrar();
    }
}
