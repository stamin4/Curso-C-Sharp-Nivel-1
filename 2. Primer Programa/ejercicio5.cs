// 5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.

using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1,nota2,nota3;
            float prom;

            Console.WriteLine("Ingrese la primera nota: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota: ");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota: ");
            nota3 = int.Parse(Console.ReadLine());
            prom = (nota1+nota2+nota3)/3f;
            Console.WriteLine("El promedio es " + prom.ToString("0.00"));
        }
    }
}
