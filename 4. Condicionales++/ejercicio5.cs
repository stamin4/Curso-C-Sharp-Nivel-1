// 5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente.

using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d;

            Console.WriteLine("Ingrese el primer número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el último número:");
            d = int.Parse(Console.ReadLine());

            if(a>b && b>c && c>d)
                Console.WriteLine("Los números están ordenados de forma decreciente.");
            else
                Console.WriteLine("Los números no están ordenados de forma decreciente."); 
        }
    }
}
