// Una compañía de electricidad necesita calcular anualmente el consumo que ha registrado cada uno de sus usuarios y el monto pagado por cada uno de ellos. 
// Para ello tiene un lote de registros para cada uno de los usuarios con los siguientes datos:

// - Zona (número entero)
// - Número de cliente (4 dígitos no correlativo)
// - Cantidad de kilowatts consumidos en el periodo

// El lote se encuentra agrupado por zona y finaliza con un registro de zona igual a cero. Se pide generar un listado con el siguiente formato: 
// zona, cantidad de usuarios de la zona, total facturado por zona.

// El precio es escalonado segun la siguiente escala:

// 10 centavos por kw --> primeros 100 kw de consumo.
// 12 centavos por kw --> de 101 a 200 kw.
// 15 centavos por kw --> de 201 kw en adelante.

using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int zona,cliente,kw,zonaAnt;
            float totalZona,totalCliente;
            int cantUsuarios;

            Console.WriteLine("Ingrese la zona:");
            zona = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de cliente:");
            cliente = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el total de kw consumidos:");
            kw = int.Parse(Console.ReadLine());

            while(zona!=0){
                zonaAnt=zona;
                totalZona=0;
                cantUsuarios=0;

                while(zona==zonaAnt){
                    cantUsuarios++;
                    if(kw<=100)
                        totalCliente=kw*0.10f;
                    else if (kw>=101 && kw<=200)
                        totalCliente=kw*0.12f;
                    else
                        totalCliente=kw*0.15f;

                    totalZona+=totalCliente;

                    Console.WriteLine("Ingrese la zona:");
                    zona = int.Parse(Console.ReadLine());

                    if(zona!=0){
                        Console.WriteLine("Ingrese el número de cliente:");
                        cliente = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el total de kw consumidos:");
                        kw = int.Parse(Console.ReadLine());
                    }
                    
                }

                Console.WriteLine("Zona: " + zonaAnt);
                Console.WriteLine("Cantidad de usuarios: " + cantUsuarios);
                Console.WriteLine("Total facturado: $" + totalZona);

            }
        }
    }
}
