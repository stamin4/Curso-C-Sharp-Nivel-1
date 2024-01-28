// 4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. 
// Que analice el número y escriba la variable recibida por referencia con:

// a. 1 si el número es positivo.
// b. -1 si el número es negativo.
// c. 0 si el número es cero.

using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,signo=0;
            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());
            positivoNegativoCero(n,ref signo);
            if(signo == 1)
                Console.WriteLine("El número es positivo");
            else if (signo == -1)
                Console.WriteLine("El número es negativo");
            else
                Console.WriteLine("El número es cero");
        }

        static void positivoNegativoCero(int n, ref int signo){
            if(n>0)
                signo=1;
            else if (n<0)
                signo=-1;
            else
                signo=0;
        }
    }
}
