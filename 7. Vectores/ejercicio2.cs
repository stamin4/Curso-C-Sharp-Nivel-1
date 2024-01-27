// 2. Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
// Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int n,acu=0,prom;
            

            for(int i=0;i<10;i++){
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                numeros[i]=n;  
            }

            for(int i=0;i<10;i++)
                acu+= numeros[i];    

            prom= acu/10;
            Console.WriteLine("El promedio es " + prom);

            for(int i=0;i<10;i++){
                if(numeros[i]>prom)
                    Console.WriteLine(numeros[i] + " es mayor al promedio");
            }

        }
    }
}