// 1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,contPrimos=0,d;

            for(int j=0;j<10;j++){
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());

                d=0;

                for(int i=1;i<=n;i++){
                    if(n%i==0)
                        d++;
                }

                if(d==2)
                    contPrimos++;

            }

            Console.WriteLine("Hay " + contPrimos + " números primos");
        }
    }
}
