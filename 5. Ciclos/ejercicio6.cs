// Hacer un programa que solicite 20 números y calcule (y emita por pantalla) cuántos son positivos. 

using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,cont=0;

            for(int i=0;i<20;i++){
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());

                if(n>0)
                    cont++;
            }

            Console.WriteLine("Hay " + cont + " números positivos");
        }
    }
}
