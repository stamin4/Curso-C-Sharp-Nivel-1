// Una compañía de turismo aventura registró los paquetes vendidos durante la última temporada vacacional. Para cada venta se ingresó:
// - Número de paquete (4 dígitos no correlativos).
// - Cantidad de personas incluidas.
// - Precio por persona.
// - Horas totales de actividades.

// Tipo de aventura:
// M para montaña.
// T para trekking.
// R para rafting.
// B para bicicleta.

// Este lote se encuentra no ordenado, pero sí agrupado por tipo de aventura y corta con número de paquete cero.

// En el lote no se ingresan registros cuyo tipo de aventura no se haya vendido. A partir de dichos datos, resolver:
// a. La cantidad de paquetes vendidos de cada tipo de aventura. 
// b. La cantidad total de personas que disfrutaron las aventuras en temporada. 
// c. El total recaudado por cada venta. 
// d. La venta con mayor importe de cada tipo de aventura. 
// e. El paquete con menos horas incurridas y en qué tipo de aventura fue.

using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int nroPaquete,personasPaquete,horas;
            float precio,totalVenta,maxVenta=0;
            char tipoAventura,tipoAventuraAnt,minAventura='A';
            int paqVendidos,personasTemp=0,minhoras=0,minPaquete=0;
            bool bandmax,bandmin=false;

            Console.WriteLine("Ingrese el número de paquete:");
            nroPaquete = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de personas incluidas:");
            personasPaquete = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio por persona:");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de horas de actividades:");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de aventura:");
            tipoAventura = char.Parse(Console.ReadLine());
            

            while(nroPaquete!=0){
                tipoAventuraAnt=tipoAventura;
                paqVendidos=0;
                bandmax=false;

                while(tipoAventura==tipoAventuraAnt && nroPaquete!=0){
                    paqVendidos++;
                    personasTemp+=personasPaquete;
                    totalVenta= personasPaquete*precio;
                    Console.WriteLine("El total recaudado por la venta es de $" + totalVenta);

                    if(!bandmax || totalVenta > maxVenta){
                        bandmax=true;
                        maxVenta=totalVenta;
                    }

                    if(!bandmin || horas < minhoras){
                        bandmin=true;
                        minhoras=horas;
                        minPaquete=nroPaquete;
                        minAventura=tipoAventura;
                    }

                    Console.WriteLine("Ingrese el número de paquete:");
                    nroPaquete = int.Parse(Console.ReadLine());

                    if(nroPaquete!=0){
                        Console.WriteLine("Ingrese la cantidad de personas incluidas:");
                        personasPaquete = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el precio por persona:");
                        precio = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la cantidad de horas de actividades:");
                        horas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el tipo de aventura:");
                        tipoAventura = char.Parse(Console.ReadLine());
                    }
                    

                }

                Console.WriteLine("La cantidad de paquetes vendidos para la aventura " + tipoAventuraAnt + " es " + paqVendidos);
                Console.WriteLine("La venta con mayor importe de la aventura " + tipoAventuraAnt + " es " + maxVenta);

            }

            Console.WriteLine("La cantidad total de personas que disfrutaron en la temporada es " + personasTemp);
            Console.WriteLine("El paquete con menor cantidad de horas incurridas es " + minPaquete + " y fue en la aventura " + minAventura);

        }
    }
}
