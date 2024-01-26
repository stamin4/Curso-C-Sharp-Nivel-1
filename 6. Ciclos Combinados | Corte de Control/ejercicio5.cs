// Hacer un programa para cargar todos números positivos que está dividido internamente en sublotes que cortan en cero.

using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0,sublote=1;

            while(n>=0){
                Console.WriteLine("Sublote " + sublote);
                Console.WriteLine("Ingrese un número (0 para cambiar de sublote | número negativo para finalizar programa):");
                n = int.Parse(Console.ReadLine());
                while(n>0){
                    Console.WriteLine("Ingrese un número (0 para cambiar de sublote | número negativo para finalizar programa):");
                    n = int.Parse(Console.ReadLine());
                }
                sublote++;
            }

        }
    }
}
