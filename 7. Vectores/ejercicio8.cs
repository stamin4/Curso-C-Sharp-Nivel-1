// Se ingresa una lista de 20 números en un vector. Se pide ordenar dichos números en forma decreciente.
// Mostrar el listado ordenado, informando también la posición original de cada número en el vector. 

using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];
            int[] vecIndices = new int[10];
            int n,aux1,aux2;

            for(int i=0;i<10;i++){
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                vector[i]=n;
            }

            for(int i=0;i<10;i++){
                vecIndices[i]=i+1;
            }

            for(int j=0;j<10;j++){
                for(int i=0;i<9;i++){
                    if(vector[i]<vector[i+1]){
                        aux1=vector[i+1];
                        vector[i+1]=vector[i];
                        vector[i]=aux1;

                        aux2=vecIndices[i+1];
                        vecIndices[i+1]=vecIndices[i];
                        vecIndices[i]=aux2;
                    }
                }           
            }

            Console.WriteLine("Vector ordenado: ");
            for(int i=0;i<10;i++){
                Console.WriteLine(vector[i] + "\t Posición original: " + vecIndices[i]);
            }




        }
    }
}
