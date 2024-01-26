// 3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
// El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0,cont,i=0;

            while(n>=0){
                cont=0;
                i++;
                Console.WriteLine("Ingrese un número (0 para cambiar de lista | número negativo para finalizar programa):");
                n = int.Parse(Console.ReadLine());
                while(n>0){
                    cont++;
                    Console.WriteLine("Ingrese un número (0 para cambiar de lista | número negativo para finalizar programa):");
                    n = int.Parse(Console.ReadLine());
                }
                if(cont>0)
                    Console.WriteLine("La lista " + i + " tiene " + cont + " números");
            }
        }
    }
}
