using System;

// Tarea semana 2 Clase Circulo que encapsula su dato primitivo (radio)
public class Circulo
{
    private double radio; // Variable privada para cumplir encapsulamiento

    // Constructor que recibe el radio
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // CalcularArea devuelve un valor double y calcula el área de un círculo
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // CalcularPerimetro devuelve un valor double y calcula el perímetro del círculo
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// Clase Rectangulo que encapsula sus datos primitivos (ancho y alto)
public class Rectangulo
{
    private double ancho;  
    private double alto;   

    // Constructor que recibe el ancho y el alto
    public Rectangulo(double ancho, double alto)
    {
        this.ancho = ancho;
        this.alto = alto;
    }

    // CalcularArea devuelve un double y calcula el área del rectángulo
    public double CalcularArea()
    {
        return ancho * alto;
    }

    // CalcularPerimetro devuelve un double y calcula el perímetro del rectángulo
    public double CalcularPerimetro()
    {
        return 2 * (ancho + alto);
    }
}

// Clase principal para probar las figuras
public class Program
{
    public static void Main()
    {
        // Crear un círculo con radio 5
        Circulo c = new Circulo(5);
        Console.WriteLine("Área del círculo: " + c.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + c.CalcularPerimetro());

        // Crear un rectángulo de 4 x 6
        Rectangulo r = new Rectangulo(4, 6);
        Console.WriteLine("Área del rectángulo: " + r.CalcularArea());
        Console.WriteLine("Perímetro del rectángulo: " + r.CalcularPerimetro());
    }
}
