//Herencia Múltiple
using System;

interface IForma
{
    void Dibujar();
}

class Circulo : IForma
{
    public void Dibujar()
    {
        Console.WriteLine("Dibujar un circulo");
    }
}

interface IColoreable
{
    void Color();
}

class RojoColor : IColoreable
{
    public void Color()
    {
        Console.WriteLine("Colorear la forma de rojo");
    }
}

class RojoCirculo : IForma, IColoreable
{
    public void Dibujar()
    {
        Console.WriteLine("Dibujar un circulo");
    }

    public void Color()
    {
        Console.WriteLine("Colorear el circulo de rojo");
    }
}

class Program
{
    static void Main(string[] args)
    {
        RojoCirculo rojoCirculo = new RojoCirculo();
        rojoCirculo.Dibujar(); // Output: Dibujar un circulo
        rojoCirculo.Color(); // Output: Colorear el circulo de rojo
    }
}

