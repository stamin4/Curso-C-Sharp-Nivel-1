// Dada una lista de 10 números, cargarlas en un vector. 
// Luego detectar si en el vector hay algún elemento repetido o no. 

using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];
            int n;
            bool band=true;

            for(int i=0;i<10;i++){
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                vector[i]=n;
            }

            for(int i=0;i<10;i++){
                for(int j=i+1;j<10;j++){
                    if(vector[i]==vector[j])
                        band=false;
                }
            }

            if(band)
                Console.WriteLine("No hay elementos repetidos");
            else
                Console.WriteLine("Hay elementos repetidos");

        }
    }
}
