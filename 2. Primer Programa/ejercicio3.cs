// 3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. 
// Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float dist,vel,tiempo;

            Console.WriteLine("Ingrese la distancia que quiere recorrer en km: ");
            dist = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad en km/h: ");
            vel = float.Parse(Console.ReadLine());
            tiempo = dist / vel;
            Console.WriteLine("Usted tardará " + tiempo.ToString("0.00") + " horas en llegar");
        }
    }
}
