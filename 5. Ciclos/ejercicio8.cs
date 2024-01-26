// Hacer un programa que solicite 10 números y luego muestre por pantalla el máximo de ellos y la posición en la que fue ingresado.

using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int max=0,n,pos=0;
            bool band=false;

            for(int i=0;i<10;i++){
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());

                if(!band || n>max){
                    band=true;
                    max=n;
                    pos=i+1;
                }
            }

            Console.WriteLine("El máximo es " + max + " y se encuentra en la posición " + pos);
        }
    }
}
