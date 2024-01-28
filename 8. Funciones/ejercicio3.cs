// 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
// Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.

using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,acu=0,cont=0,prom;

            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());
            while(n!=0){
                if(primo(n)){
                    acu+=n;
                    cont++;
                }
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
            }

            prom=acu/cont;
            Console.WriteLine("El promedio de números primos es " + prom);
            
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

    }
}
