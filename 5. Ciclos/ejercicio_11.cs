// Hacer un programa que solicite la edad de un grupo de personas. 
// El programa deberá pedir edades hasta que se ingrese una edad menor a 18 y deberá mostrar por pantalla cuántas personas de 18 años o más se registraron.

using System;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad,cont=0;

            Console.WriteLine("Ingrese la edad:");
            edad = int.Parse(Console.ReadLine());

            while(edad>18){
                cont++;
                Console.WriteLine("Ingrese la edad:");
                edad = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Se registraron " + cont + " personas mayores de 18 años");
        }
    }
}
