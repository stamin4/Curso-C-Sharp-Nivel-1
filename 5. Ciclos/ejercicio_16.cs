// Hacer un programa que solicite una lista de números que corta cuando se ingresa un cero. 
// Luego mostrar la cantidad de números primos, la cantidad de números pares, positivos y negativos

using System;

namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,contPares=0,contPos=0,contNeg=0,contPrimos=0,d;

            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());

            while(n!=0){

                if(n<0)
                    contNeg++;
                else 
                    contPos++;

                if(n%2==0)
                    contPares++;

                d=0;
                
                for(int i=1;i<=n;i++){
                    if(n%i==0)
                        d++;
                }

                if(d==2)
                    contPrimos++;


                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Números primos: " + contPrimos);
            Console.WriteLine("Números pares: " + contPares);
            Console.WriteLine("Números positivos: " + contPos);
            Console.WriteLine("Números negativos: " + contNeg);
        }
    }
}
