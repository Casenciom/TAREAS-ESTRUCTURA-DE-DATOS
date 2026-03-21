class Program
{
    static void Main(string[] args)
    {
        ArbolBST arbol = new ArbolBST();
        int opcion;

        do
        {
            Console.WriteLine("\n--- MENÚ BST ---");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Buscar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Inorden");
            Console.WriteLine("5. Preorden");
            Console.WriteLine("6. Postorden");
            Console.WriteLine("7. Mínimo");
            Console.WriteLine("8. Máximo");
            Console.WriteLine("9. Altura");
            Console.WriteLine("10. Limpiar");
            Console.WriteLine("0. Salir");

            Console.Write("Opción: ");
            if (!int.TryParse(Console.ReadLine(), out opcion))
                continue;

            switch (opcion)
            {
                case 1:
                    Console.Write("Valor: ");
                    if (int.TryParse(Console.ReadLine(), out int v1))
                        arbol.Raiz = arbol.Insertar(arbol.Raiz, v1);
                    break;

                case 2:
                    Console.Write("Buscar: ");
                    if (int.TryParse(Console.ReadLine(), out int v2))
                        Console.WriteLine(arbol.Buscar(arbol.Raiz, v2) ? "Encontrado" : "No encontrado");
                    break;

                case 3:
                    Console.Write("Eliminar: ");
                    if (int.TryParse(Console.ReadLine(), out int v3))
                        arbol.Raiz = arbol.Eliminar(arbol.Raiz, v3);
                    break;

                case 4:
                    arbol.Inorden(arbol.Raiz);
                    Console.WriteLine();
                    break;

                case 5:
                    arbol.Preorden(arbol.Raiz);
                    Console.WriteLine();
                    break;

                case 6:
                    arbol.Postorden(arbol.Raiz);
                    Console.WriteLine();
                    break;

                case 7:
                    if (arbol.Raiz != null)
                        Console.WriteLine("Mínimo: " + arbol.MinValor(arbol.Raiz));
                    break;

                case 8:
                    if (arbol.Raiz != null)
                        Console.WriteLine("Máximo: " + arbol.Maximo(arbol.Raiz));
                    break;

                case 9:
                    Console.WriteLine("Altura: " + arbol.Altura(arbol.Raiz));
                    break;

                case 10:
                    arbol.Limpiar();
                    Console.WriteLine("Árbol limpio");
                    break;
            }

        } while (opcion != 0);
    }
}