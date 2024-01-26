// 5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.

using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,max=0,min=0;
            bool bandmax=false,bandmin=false;

            for(int i=0;i<20;i++){
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());

                if(n % 2 == 0){
                    if(!bandmax || n>max){
                        bandmax=true;
                        max=n;
                    }
                }
                else{
                    if(!bandmin || n<min){
                        bandmin=true;
                        min=n;
                    }
                }
            }

            Console.WriteLine("El máximo par es " + max);
            Console.WriteLine("El mínimo impar es " + min);
        }
    }
}
