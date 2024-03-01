//Herencia de Atributos y Métodos
using System;

class Forma
{
    protected int ancho;
    protected int alto;

    public void SetAncho(int w)
    {
        ancho = w;
    }

    public void SetAlto(int h)
    {
        alto = h;
    }
}

class Rectángulo : Forma
{
    public int GetArea()
    {
        return ancho * alto;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectángulo rect = new Rectángulo();
        rect.SetAncho(5);
        rect.SetAlto(4);
        Console.WriteLine("Area del rectángulo: " + rect.GetArea()); // Output: Area del rectángulo: 20
    }
}
