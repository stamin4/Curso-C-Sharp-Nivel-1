// 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
// - Número de Artículo (1 a 15)
// - Cantidad Vendida 

// Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
// Se pide determinar e informar:
// a) El número de artículo que más se vendió en total.
// b) Los números de artículos que no registraron ventas.
// c) Cuantas unidades se vendieron del número de artículo 10.

using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vectorVentas = new int[15];
            int nroart,cant=0,nroartMax=0,max=0;
            bool bandMax=false;

            Console.WriteLine("Ingrese el número de artículo: ");
            nroart = int.Parse(Console.ReadLine());

            while(nroart!=0){
                Console.WriteLine("Ingrese la cantidad vendida: ");
                cant = int.Parse(Console.ReadLine());
                vectorVentas[nroart-1]+=cant;
                Console.WriteLine("Ingrese el número de artículo: ");
                nroart = int.Parse(Console.ReadLine());
            }

            for(int i=0;i<15;i++){
                if(vectorVentas[i]>max || !bandMax){
                    bandMax=true;
                    max=vectorVentas[i];
                    nroartMax=i+1;
                }
            }

            Console.WriteLine("El número de artículo que más se vendió en total es " + nroartMax);

            for(int i=0;i<15;i++){
                if(vectorVentas[i]==0){
                    Console.WriteLine("El artículo " + (i+1) + " no registró ventas");
                }
            }

            Console.WriteLine("Se vendieron " + vectorVentas[9] + " unidades del artículo 10");

        }
    }
}
