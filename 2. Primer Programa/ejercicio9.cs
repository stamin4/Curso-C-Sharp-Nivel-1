// Una universidad desea conocer los porcentajes de mujeres y hombres en las carreras de Ciencias Exactas. 
// Se solicita un programa para cargar la cantidad de mujeres y la cantidad de hombres, y que el mismo calcule y emita por pantalla los porcentajes correspondientes. 

using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int m,h,total;
            float pm,ph;

            Console.WriteLine("Ingrese la cantidad de mujeres: ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de hombres: ");
            h = int.Parse(Console.ReadLine());
            total = m+h;
            pm = (m*100f)/total;
            ph = (h*100f)/total;
            Console.WriteLine("Porcentaje de mujeres: " + pm.ToString("0.00") + "%");
            Console.WriteLine("Porcentaje de hombres: " + ph.ToString("0.00") + "%");
        }
    }
}
