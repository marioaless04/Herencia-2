//Herencia de Constructores
using System;

class Padre
{
    public Padre()
    {
        Console.WriteLine("Constructor de la clase Padre");
    }
}

class Hijo : Padre
{
    public Hijo() : base()
    {
        Console.WriteLine("Constructor de la clase Hijo");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Hijo hijo = new Hijo();
        // Output:
        // Constructor de la clase Padre
        // Constructor de la clase Hijo
    }
}
