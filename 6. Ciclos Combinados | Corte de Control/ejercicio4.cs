// Hacer un programa para ingresar 5 sublotes de números separados entre sí por un cero.

using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            for(int i=0;i<5;i++){
                Console.WriteLine("Sublote " + (i+1));
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());

                while(n!=0){
                    Console.WriteLine("Ingrese un número:");
                    n = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
