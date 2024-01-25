//4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d,menor;

            Console.WriteLine("Ingrese primer número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo número:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tercer número:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el último número:");
            d = int.Parse(Console.ReadLine());

            if(a < b)
                menor = a;
            else
                menor = b;

            if(c < menor)
                menor = c;

            if(d < menor)
                menor = d;

            Console.WriteLine("El menor es " + menor);
        }
    }
}
