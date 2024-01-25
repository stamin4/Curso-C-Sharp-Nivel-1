// 5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d;

            Console.WriteLine("Ingrese primer número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo número:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tercer número:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el último número:");
            d = int.Parse(Console.ReadLine());

            if(a > 100)
                Console.WriteLine(a + " es mayor a 100");
            if(b > 100)
                Console.WriteLine(b + " es mayor a 100");
            if(c > 100)
                Console.WriteLine(c + " es mayor a 100");
            if(d > 100)
                Console.WriteLine(d + " es mayor a 100");
        }
    }
}
