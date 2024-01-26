// Hacer un programa que solicite dos números y luego muestre los números entre el menor y el mayor de ellos.

using System;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,max,min;

            Console.WriteLine("Ingrese un número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número:");
            b = int.Parse(Console.ReadLine());

            if(a>b){
                max=a;
                min=b;
            }
            else{
                max=b;
                min=a;
            }

            while(min<=max){
                Console.WriteLine(min);
                min++;
            }

        }
    }
}
