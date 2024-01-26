// 3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad,acu=0,cont=0,prom;

            for(int i=0;i<20;i++){
                Console.WriteLine("Ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());

                if(edad>18){
                    acu+=edad;
                    cont++;
                }
            }

            prom = acu / cont;
            Console.WriteLine("El promedio de edad (mayores a 18) es de " + prom);
        }
    }
}
