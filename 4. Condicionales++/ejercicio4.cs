// 4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;

            Console.WriteLine("Ingrese el primer número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el último número:");
            c = int.Parse(Console.ReadLine());

            if((a + b) > (b * c))
                Console.WriteLine("La suma de los dos primeros es mayor al producto del segundo con el tercero.");
        }
    }
}
