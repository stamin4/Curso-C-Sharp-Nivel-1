// Hacer un programa que solicite una lista de números que corta cuando se ingresa un cero. 
// Luego emitir por pantalla el máximo de los negativos y el mínimo de los positivos.

using System;

namespace ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int max=0,min=0,n;
            bool bandMax=false,bandMin=false;

            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());

            while(n!=0){
                
                if(n>0){
                    if(!bandMin || n<min){
                        bandMin=true;
                        min=n;
                    }
                }
                else{
                    if(!bandMax || n>max){
                        bandMax=true;
                        max=n;
                    }
                }
                
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El máximo de los negativos es " + max);
            Console.WriteLine("El mínimo de los positivos es " + min);

        }
    }
}
