/*Cree un programa que permita definir una clase base <<Pais>> que sea abstracta.
a. En la misma debe definir los siguientes métodos abstractos <<ColorBandera>>, <<Tamaño>>, <<IdiomaOficial>>
b. Debe heredar sus métodos a <<Ecuador>>, <<Brasil>>, <<Andorra>>
c. En el main. Muestre el color de la bandera de Ecuador, el Tamaño de Andorra y el Idioma de Brasil */
using System;

// Definición de la clase base abstracta Pais
abstract class Pais
{
    // Métodos abstractos que deben ser implementados por las clases derivadas
    public abstract string ColorBandera();
    public abstract string Tamaño();
    public abstract string IdiomaOficial();
}

// Definición de la clase derivada Ecuador
class Ecuador : Pais
{
    // Implementación de los métodos abstractos
    public override string ColorBandera()
    {
        return "Amarillo, Azul y Rojo";
    }

    public override string Tamaño()
    {
        return "283,561 km²";
    }

    public override string IdiomaOficial()
    {
        return "Español";
    }
}

// Definición de la clase derivada Brasil
class Brasil : Pais
{
    // Implementación de los métodos abstractos
    public override string ColorBandera()
    {
        return "Verde y Amarillo";
    }

    public override string Tamaño()
    {
        return "8.51 millones km²";
    }

    public override string IdiomaOficial()
    {
        return "Portugués";
    }
}

// Definición de la clase derivada Andorra
class Andorra : Pais
{
    // Implementación de los métodos abstractos
    public override string ColorBandera()
    {
        return "Azul, Amarillo y Rojo";
    }

    public override string Tamaño()
    {
        return "468 km²";
    }

    public override string IdiomaOficial()
    {
        return "Catalán";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear instancias de las clases derivadas
        Ecuador ecuador = new Ecuador();
        Brasil brasil = new Brasil();
        Andorra andorra = new Andorra();

        // Mostrar información de los países
        Console.WriteLine("Color de la bandera de Ecuador: " + ecuador.ColorBandera());
        Console.WriteLine("Tamaño de Andorra: " + andorra.Tamaño());
        Console.WriteLine("Idioma de Brasil: " + brasil.IdiomaOficial());
    }
}
