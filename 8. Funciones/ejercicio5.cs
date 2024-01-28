// Hacer una función llamada "pagos" que reciba un monto total (float) y una cantidad de pagos (int) y que devuelva el monto de cada pago. 
// Hacer un programa para ingresar 10 ventas. Para cada venta se conoce el monto y la cantidad de pagos.
// El programa deberá mostrar la cantidad de pagos y el monto del pago para cada una de las ventas. 

using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            float montoTotal,montoPago;
            int cantPagos;

            for(int i=0;i<10;i++){
                Console.WriteLine("Ingrese el monto total:");
                montoTotal = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de pagos:");
                cantPagos = int.Parse(Console.ReadLine());
                Console.WriteLine("Venta N° " + (i+1));
                Console.WriteLine("Cantidad de pagos: " + cantPagos);
                montoPago = pagos(montoTotal, cantPagos);
                Console.WriteLine("Monto por pago: " + montoPago);
            }
        }

        static float pagos(float montoTotal, int cantPagos){
            float montoPago;
            montoPago=montoTotal/cantPagos;
            return montoPago;
        }
    }
}
