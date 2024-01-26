// Hacer un programa para ingresar por teclado los m2 totales de un predio y los m2 cubiertos. 
// Luego calcular y mostrar por pantalla el porcentaje de m2 cubiertos y descubiertos. 

using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int mt,mc,pmc,pmd;

            Console.WriteLine("Ingrese la cantidad de metros cuadrados totales del predio: ");
            mt = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de metros cuadrados cubiertos: ");
            mc = int.Parse(Console.ReadLine());
            pmc = (mc*100)/mt;
            pmd = 100-pmc;
            Console.WriteLine("Porcentaje de metros cuadrados cubiertos: " + pmc + "%");
            Console.WriteLine("Porcentaje de metros cuadrados descubiertos: " + pmd + "%");
        }
    }
}
