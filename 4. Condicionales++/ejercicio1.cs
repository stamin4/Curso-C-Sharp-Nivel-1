// 1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

//          La resta si el primero es mayor que el segundo.
//          La suma si son iguales.
//          El producto si el primero es menor.

// Se deberá emitir un cartel por pantalla con el resultado correspondiente.

using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,r;

            Console.WriteLine("Ingrese un número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número:");
            b = int.Parse(Console.ReadLine());

            if(a == b)
                r = a+b;
            else{
                if(a > b)
                    r = a-b;
                else
                    r = a*b;
            }

            Console.WriteLine("El resultado es " + r);

        }
    }
}
