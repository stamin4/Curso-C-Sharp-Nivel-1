// Una importante cadena de delivery cuenta con una promoción por tiempo limitado en la que otorga un 15% de descuento sobre el total del valor de la compra realizada. 
// Hacer un programa para solicitar el monto total, y que el mismo calcule y emita por pantalla el total a cobrar con el descuento aplicado. 

using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            float total,desc,monto;

            Console.WriteLine("Ingrese el total de la compra: ");
            total = float.Parse(Console.ReadLine());
            desc = (15 * total) / 100;
            monto = total-desc;
            Console.WriteLine("El total a pagar es: $" + monto);
        }
    }
}
