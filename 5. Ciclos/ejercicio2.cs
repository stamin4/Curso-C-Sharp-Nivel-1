// 2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,max=0;
            bool band=false;

            for(int i=0;i<10;i++){
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());

                if(!band || n>max){
                    band = true;
                    max = n;
                }
            }

            Console.WriteLine("El máximo es " + max);
        }
    }
}
