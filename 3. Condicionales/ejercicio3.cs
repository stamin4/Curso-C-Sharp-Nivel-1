// 3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:

//  Si el importe es menor a ARS 1000, no hay descuento.
//  Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
//  Si el importe es ARS 5000 o más, aplica un descuento del 18%.

// Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.

using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float imp,impfinal,desc;

            Console.WriteLine("Ingrese el importe: ");
            imp = float.Parse(Console.ReadLine());

            if(imp < 1000)
                impfinal = imp;
            else{
                if(imp < 5000)
                    desc = imp*10 / 100;
                else
                    desc = imp*18 / 100;
                impfinal = imp - desc;
            }
            Console.WriteLine("El importe final es de $" + impfinal.ToString("0.00"));
        }
    }
}
