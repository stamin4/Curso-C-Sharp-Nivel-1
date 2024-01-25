//1. Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.

using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro1,nro2,suma;

            Console.WriteLine("Ingrese un número: ");
            nro1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            nro2 = int.Parse(Console.ReadLine());

            suma = nro1 + nro2;

            Console.WriteLine("El resultado de la suma entre " + nro1 + " y " + nro2 + " es " + suma);
        }
    }
}
