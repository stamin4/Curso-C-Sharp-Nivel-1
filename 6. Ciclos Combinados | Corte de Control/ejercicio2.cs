// 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

//     El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
//     Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,contP,contI,total,porImp,maxImp=0,grupo=0,min=0,grupoOrd=0;
            bool bandMax=false,bandOrdenado;

            for(int i=0;i<5;i++){
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());

                contP=0;
                contI=0;
                total=0;
                bandOrdenado=true;
                min=n;

                while(n!=0){
                    if(n%2==0)    
                        contP++;
                    else
                        contI++;

                    if(n<=min){
                        min=n;
                    }
                    else
                        bandOrdenado=false;

                    Console.WriteLine("Ingrese un número:");
                    n = int.Parse(Console.ReadLine());
                }

                total=contP+contI;
                porImp=contI*100/total;

                if(!bandMax || porImp>maxImp){
                    bandMax=true;
                    maxImp=porImp;
                    grupo=i+1;
                }

                if(bandOrdenado==true)
                    grupoOrd++;

            }

            Console.WriteLine("El número de grupo con mayor porcentaje de números impares es " + grupo);
            Console.WriteLine("Hay " + grupoOrd + " grupos formados por todos números ordenados de mayor a menor");
        }
    }
}
