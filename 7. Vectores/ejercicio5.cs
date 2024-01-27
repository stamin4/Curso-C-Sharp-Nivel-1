// Hacer un programa que solicite 50 números enteros y los guarde en un vector.
// Luego recorrer el vector y determinar e informar cuál es la suma de los valores del mismo. 
// Nota: Realizar dos ciclos. 

using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[50];
            int n,suma=0;

            for(int i=0;i<50;i++){
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
                vector[i]=n;
            }

            for(int i=0;i<50;i++){
                suma+= vector[i];
            }

            Console.WriteLine("La suma da como resultado " + suma);
        }
    }
}
