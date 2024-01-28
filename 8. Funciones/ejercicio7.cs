// Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero.
// A partir de dichos datos, informar:
// - El mayor de los números pares.
// - La cantidad de números impares.
// - El menor de los números primos. 

using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,maxPar=0,contImpar=0,minPrimo=0;
            bool bandMax=false,bandMin=false;
            
            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());

            while(n!=0){
                if(par(n)){
                    if(mayor(n,maxPar) || !bandMax){
                        maxPar=n;
                        bandMax=true;
                    }  
                }
                else
                    contImpar++;

                if(primo(n)){
                    if(!(mayor(n,minPrimo)) || !bandMin){
                        minPrimo=n;
                        bandMin=true;
                    }
                }

                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El máximo par es: " + maxPar);
            Console.WriteLine("La cantidad de impares es: " + contImpar);
            Console.WriteLine("El mínimo primo es: " + minPrimo);
        }

        static bool primo(int n){
        int d=0;
        for(int i=1;i<=n;i++){
            if(n%i==0)
                d++;
        }
        if(d>2)
            return false;
        else
            return true;
        }


        static bool par(int n){
        if(n%2 == 0)
            return true;
        else
            return false;
        }    


        static bool mayor(int n1,int n2){
            if(n1>n2)
                return true;
            else
                return false;
        }

    }  
}
