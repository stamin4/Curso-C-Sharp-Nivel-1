// Hacer un programa para ingresar 4 números y mostrar por pantalla cuántos son menores a 100. 

using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d,cont=0;

            Console.WriteLine("Ingrese el primer número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el último número:");
            d = int.Parse(Console.ReadLine());

            if(a<100)
                cont++;
            if(b<100)
                cont++;
            if(c<100)
                cont++;
            if(d<100)
                cont++;

            Console.WriteLine("Hay " + cont + " números menores a 100.");
        }
    }
}
