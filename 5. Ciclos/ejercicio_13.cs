// Hacer un programa que solicite una lista de números que corta cuando se ingresa un cero. 
// Luego mostrar por pantalla el máximo de ellos y la posición en la que fue ingresado.

using System;

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,max=0,i=0,posMax=0;
            bool band = false;

            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());
            while(n != 0){
                i++;
                if(n > max || band == false){
                    max=n;
                    posMax=i;
                    band=true;
                }
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El número máximo ingresado es " + max + " y se encuentra en la posición " + posMax);
        }
    }
}
