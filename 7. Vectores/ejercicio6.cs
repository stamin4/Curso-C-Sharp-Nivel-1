// Dada una lista de 10 números enteros, cargarlos en un vector. 
// Luego determinar e informar si el vector está ordenado en forma creciente. 

using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];
            int n,ant;
            bool band=true;

            for(int i=0;i<10;i++){
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                vector[i]=n;
            }

            ant = vector[0];
            for(int i=1;i<10;i++){
                if(vector[i]>ant)
                    ant=vector[i];
                else
                    band=false; 
            }

            if(band)
                Console.WriteLine("El vector está ordenado");
            else
                Console.WriteLine("El vector no está ordenado");
        }
    }
}
