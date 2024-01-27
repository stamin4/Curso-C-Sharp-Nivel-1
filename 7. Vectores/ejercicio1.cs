// 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
// Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int n,max=0,posMax=0;
            bool band=false;

            for(int i=0;i<10;i++){
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                numeros[i]=n;  
            }

            for(int i=0;i<10;i++){
                if(numeros[i]>max || !band){
                    max=numeros[i];
                    band=true;
                    posMax=i+1;
                }
            }

            Console.WriteLine("El maximo es " + max + " y se encuentra en la posición " + posMax);
          
        }
    }
}
