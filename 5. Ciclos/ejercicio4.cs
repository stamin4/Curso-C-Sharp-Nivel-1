// 4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  
// Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,d=0;

            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());

            for(int i=1;i<=n;i++){
                if(n % i == 0)
                    d++;
            }

            if(d == 2)
                Console.WriteLine("Es primo");
            else
                Console.WriteLine("No es primo");
        }
    }
}
