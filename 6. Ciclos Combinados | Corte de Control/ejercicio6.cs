// Dada una lista de números compuesta por 10 sublotes y cada sublote separado del siguiente por un cero, se debe determinar e informar:
// a. Para cada uno de los sublotes, el máximo de los pares y el máximo de los impares.
// b. Para cada sublote el porcentaje de números positivos y de números negativos.
// c. Cuántos números había en total entre los 10 sublotes sin contar los ceros que separan a cada subgrupo.

using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,maxp=0,maxi=0,contp,contn,totalSublote,total=0,pos,neg;
            bool bandp,bandi;

            for(int i=0;i<10;i++){
                Console.WriteLine("Ingrese un número:");
                n= int.Parse(Console.ReadLine());

                bandp=false;
                bandi=false;
                contp=0;
                contn=0;
                totalSublote=0;
        

                while(n!=0){

                    if(n%2==0){
                        if(!bandp || n>maxp){
                            bandp=true;
                            maxp=n;
                        }
                    }
                    else{
                        if(!bandi || n>maxi){
                            bandi=true;
                            maxi=n;
                        }
                    }
                    

                    if(n>0)
                        contp++;
                    else
                        contn++;


                    Console.WriteLine("Ingrese un número:");
                    n= int.Parse(Console.ReadLine());

                }

                Console.WriteLine("El máximo par es " + maxp);
                Console.WriteLine("El máximo impar es " + maxi);
                totalSublote=contp+contn;
                total+=totalSublote;
                pos=contp*100/totalSublote;
                neg=contn*100/totalSublote;
                Console.WriteLine("El porcentaje de números positivos es " + pos + "%");
                Console.WriteLine("El porcentaje de números negativos es " + neg + "%");

            }

            Console.WriteLine("En total se ingresaron " + total + " números");
        }
    }
}
