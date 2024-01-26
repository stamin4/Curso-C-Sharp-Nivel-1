// Hacer un programa que solicite 20 números y luego mostrar por pantalla el menor de ellos y la posición en la que fue encontrado.

using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int min=0,n,pos=0;
            bool band=false;

            for(int i=0;i<20;i++){
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());

                if(!band || n<min){
                    band=true;
                    min=n;
                    pos=i+1;
                }
            }

            Console.WriteLine("El mínimo es " + min + " y se encuentra en la posición " + pos);
        }
    }
}
