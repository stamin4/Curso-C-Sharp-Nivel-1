// Hacer un programa para ingresar 4 números distintos y mostrar por pantalla el mayor de ellos. 

using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d,max;

            Console.WriteLine("Ingrese el primer número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el último número:");
            d = int.Parse(Console.ReadLine());

            if(a>b)
                max=a;
            else
                max=b;
            
            if(c>max)
                max=c;
            
            if(d>max)
                max=d;
            
            Console.WriteLine("El máximo es " + max);
        }
    }
}
