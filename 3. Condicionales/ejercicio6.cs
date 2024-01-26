// Hacer un programa que permita ingresar un número y determinar si el mismo es par o impar. 

using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());

            if(n%2 == 0)
                Console.WriteLine("El número " + n + " es par");
            else
                Console.WriteLine("El número " + n + " es impar");
        }
    }
}
