class ArbolBST
{
    public Nodo? Raiz;

    public ArbolBST()
    {
        Raiz = null;
    }

    public Nodo Insertar(Nodo? nodo, int valor)
    {
        if (nodo == null)
            return new Nodo(valor);

        if (valor < nodo.Valor)
            nodo.Izquierdo = Insertar(nodo.Izquierdo, valor);
        else if (valor > nodo.Valor)
            nodo.Derecho = Insertar(nodo.Derecho, valor);

        return nodo;
    }

    public bool Buscar(Nodo? nodo, int valor)
    {
        if (nodo == null)
            return false;

        if (valor == nodo.Valor)
            return true;
        else if (valor < nodo.Valor)
            return Buscar(nodo.Izquierdo, valor);
        else
            return Buscar(nodo.Derecho, valor);
    }

    public Nodo Minimo(Nodo nodo)
    {
        while (nodo.Izquierdo != null)
            nodo = nodo.Izquierdo;

        return nodo;
    }

    public Nodo? Eliminar(Nodo? nodo, int valor)
    {
        if (nodo == null)
            return null;

        if (valor < nodo.Valor)
            nodo.Izquierdo = Eliminar(nodo.Izquierdo, valor);
        else if (valor > nodo.Valor)
            nodo.Derecho = Eliminar(nodo.Derecho, valor);
        else
        {
            if (nodo.Izquierdo == null && nodo.Derecho == null)
                return null;

            if (nodo.Izquierdo == null)
                return nodo.Derecho;

            if (nodo.Derecho == null)
                return nodo.Izquierdo;

            Nodo sucesor = Minimo(nodo.Derecho!);
            nodo.Valor = sucesor.Valor;
            nodo.Derecho = Eliminar(nodo.Derecho, sucesor.Valor);
        }

        return nodo;
    }

    public void Inorden(Nodo? nodo)
    {
        if (nodo != null)
        {
            Inorden(nodo.Izquierdo);
            Console.Write(nodo.Valor + " ");
            Inorden(nodo.Derecho);
        }
    }

    public void Preorden(Nodo? nodo)
    {
        if (nodo != null)
        {
            Console.Write(nodo.Valor + " ");
            Preorden(nodo.Izquierdo);
            Preorden(nodo.Derecho);
        }
    }

    public void Postorden(Nodo? nodo)
    {
        if (nodo != null)
        {
            Postorden(nodo.Izquierdo);
            Postorden(nodo.Derecho);
            Console.Write(nodo.Valor + " ");
        }
    }

    public int Maximo(Nodo nodo)
    {
        while (nodo.Derecho != null)
            nodo = nodo.Derecho;

        return nodo.Valor;
    }

    public int MinValor(Nodo nodo)
    {
        while (nodo.Izquierdo != null)
            nodo = nodo.Izquierdo;

        return nodo.Valor;
    }

    public int Altura(Nodo? nodo)
    {
        if (nodo == null)
            return -1;

        int izquierda = Altura(nodo.Izquierdo);
        int derecha = Altura(nodo.Derecho);

        return Math.Max(izquierda, derecha) + 1;
    }

    public void Limpiar()
    {
        Raiz = null;
    }
}