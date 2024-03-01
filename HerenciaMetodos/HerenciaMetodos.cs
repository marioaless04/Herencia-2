//Herencia de Métodos Especiales
using System;

class Forma
{
    public virtual void Dibujar()
    {
        Console.WriteLine("Dibujar una forma");
    }
}

class Circulo : Forma
{
    public override void Circulo()
    {
        Console.WriteLine("Dibujar un circulo");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Forma forma = new Circulo();
        forma.Dibujar(); // Output: Dibujar un circulo
    }
}
