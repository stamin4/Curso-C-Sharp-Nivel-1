// Una casa de videojuegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:
// Si el importe es menor a $1000 -> no hay descuento.
// Si el importe es de $1000 o más, pero menor a 5000 -> el descuento es del 10%
// Si el importe es $5000 o más -> el descuento a aplicar es del 18%
// Hacer un programa para ingresar el importe de venta y que luego muestre por pantalla el importe final con el descuento correspondiente. 

using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            float imp,desc,final;
            
            Console.WriteLine("Ingrese el importe de la compra:");
            imp = float.Parse(Console.ReadLine());

            if (imp < 1000)
                final = imp;
            else{
                if(imp>=1000 && imp<5000){
                    desc = imp * 10 / 100;
                    final = imp - desc;
                }
                else{
                    desc = imp * 18 / 100;
                    final = imp - desc;
                }
            }
            Console.WriteLine("El importe final es de $" + final.ToString("0.00"));
        }
    }
}
