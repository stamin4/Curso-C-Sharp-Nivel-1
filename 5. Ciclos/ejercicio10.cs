// Hacer un programa para ingresar 10 números y luego calcule el mayor de los primos de la lista. 
// En caso de no haber ningún número primo, deberá aclararlo con un cartel.

using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,d,max=0,contPrimos=0;
            bool band=false;

            for(int j=0;j<10;j++){

                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());

                d=0;

                for(int i=1;i<=n;i++){
                    if(n%i == 0)
                        d++;
                }

                if(d==2){
                    if(!band || n>max){
                        band=true;
                        max=n;
                        contPrimos++;
                    }
                }
            }

        if(contPrimos==0)
            Console.WriteLine("No se ingresaron números primos");
        else
            Console.WriteLine("El mayor número primo es " + max);
        }
    }

}
