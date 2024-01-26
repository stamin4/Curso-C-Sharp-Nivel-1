// Hacer un programa que permita ingresar el año actual y el año de la fecha de nacimiento de una persona. Luego calcule y emita por pantalla su edad. 
// Nota: NO hay que tener en cuenta si la persona cumplió o no años. 

using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int añonac,añoact,edad;

            Console.WriteLine("Ingrese su año de nacimiento: ");
            añonac = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año actual: ");
            añoact = int.Parse(Console.ReadLine());
            edad = añoact-añonac;
            Console.WriteLine("Tiene " + edad + " años");
        }
    }
}
