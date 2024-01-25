// 2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

//          Si vende menos de 100 litros, no hay descuento.
//          Si vende entre 101 y 300 litros, el descuento es del 10%.
//          Si vende entre 301 y 500 litros, el descuento es del 15%.
//          Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

// Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento aplicado.

using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float imp,l,final,desc;

            Console.WriteLine("Ingrese la cantidad de litros vendidos:");
            l = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el importe:");
            imp = float.Parse(Console.ReadLine());

            if(l <= 100)
                final = imp;
            else if(l>100 && l<=300){
                desc = imp*10/100;
                final = imp-desc;
            }
            else if(l>300 && l<=500){
                desc = imp*15/100;
                final = imp-desc;
            }
            else{
                desc = imp*25/100;
                final = imp-desc;
            }

            Console.WriteLine("El importe final es de $" + final.ToString("0.00"));    

        }
    }
}
