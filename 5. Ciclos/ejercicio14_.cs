// Hacer un programa que solicite una lista de números que corta cuando se ingresa un cero. 
// Luego mostrar por pantalla el menor y el segundo menor, así como también las posiciones en las que fueron ingresados.

using System;

namespace ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int m1,m2=0, n,p=1,p1,p2=0;
            bool band=false;

            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());
            m1=n;
            p1=p;
            while(n != 0){
                if(n<m1){
                    m2=m1;
                    m1=n;
                    p2=p1;
                    p1=p;
                    band=true;
                }
                else{
                    if(!band){
                        band=true;
                        m2=n;
                        p2=p;
                    }
                    else{
                        if(n<m2){
                            m2=n;
                            p2=p;
                        }
                    }
                }
                p++;
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Menor: " + m1 + " Posición: " + p1);
            Console.WriteLine("Segundo menor: " + m2 + " Posición: " + p2);
        }
    }
}
