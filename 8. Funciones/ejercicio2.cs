// 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
// Hacer un programa para ingresar 10 números y mostrar por pantalla cuántos son pares.

using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,contPares=0;

            for(int i=0;i<10;i++){
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());

                if(par(n))
                    contPares++; 
            }

            Console.WriteLine("Hay " + contPares + " números pares");
           

        }

        static bool par(int n){
            if(n%2 == 0)
                return true;
            else
                return false;
        }
    }
}
