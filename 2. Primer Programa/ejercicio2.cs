// 2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.

using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro,cubo;
            
            Console.WriteLine("Ingrese un número: ");
            nro = int.Parse(Console.ReadLine());
            cubo = nro * nro * nro;
            Console.WriteLine("El cubo del número " + nro + " es " + cubo);
        }
    }
}
