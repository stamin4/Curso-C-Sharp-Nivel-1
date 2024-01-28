// Hacer una función que se llame sumaResta que reciba dos números y que devuelva la suma y la resta del primero con el segundo. 

using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,suma=0,resta=0;

            Console.WriteLine("Ingrese un número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            n2 = int.Parse(Console.ReadLine());

            sumaResta(n1,n2,ref suma,ref resta);

            Console.WriteLine("La suma da " + suma);
            Console.WriteLine("La resta da " + resta);
        }

        static void sumaResta(int n1,int n2,ref int suma,ref int resta){
            suma=n1+n2;
            resta=n1-n2;
        }
    }
}
