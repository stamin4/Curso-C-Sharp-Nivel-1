// 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
// Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. 
// Usar la función.

using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio,cantidad,monto;

            Console.WriteLine("Ingrese el precio del artículo:");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida:");
            cantidad = int.Parse(Console.ReadLine());
            monto = producto(precio,cantidad);
            Console.WriteLine("El monto a pagar es $" + monto);


        }

        static int producto(int a,int b){
            int p;
            p=a*b;
            return p;
        }

    }
}
