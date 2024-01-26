// Hacer un programa para ingresar los valores de los pesos de distintas encomiendas que se deben enviar a distintos clientes 
// y que finaliza cuando se ingresa un peso negativo. 
// Se deben agrupar las encomiendas en camiones que pueden transportar hasta 200 kilos en total. Se pide determinar e informar:
//  - El número de camión y peso total de encomiendas.
//  - El número de camión que transporta mayor cantidad de encomiendas.
//  - La cantidad de camiones que se terminaron cargando.

using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int pesoEnc,pesoCamion,camion,enc,maxEnc=0,camionMax=0;
            bool band=false;

            camion=0;
            Console.WriteLine("Ingrese el peso de la encomienda:");
            pesoEnc = int.Parse(Console.ReadLine());

            while(pesoEnc>0){
                pesoCamion=0;
                enc=0;
                camion++;
                while(pesoEnc + pesoCamion <= 200 && pesoEnc>0){
                    pesoCamion+=pesoEnc;
                    enc++;
                    Console.WriteLine("Ingrese el peso de la encomienda:");
                    pesoEnc = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Número de camión: " + camion);
                Console.WriteLine("Peso total de encomiendas: " + pesoCamion);

                if(!band || enc>maxEnc){
                    band=true;
                    maxEnc=enc;
                    camionMax=camion;

                }
            }
            if(camion!=0){
                Console.WriteLine("El camión que transporta la mayor cantidad de encomiendas es " + camionMax);
                Console.WriteLine("En total se cargaron " + camion + " camiones");
            }
            
        }
    }
}
