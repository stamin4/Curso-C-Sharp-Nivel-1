// 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
// El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. 
// Mostrar el resultado en pantalla. Ejemplo:
// CADENA FUENTE: “La mar estaba serena"
// CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
// CADENA RESULTADO: “Li mir estibi sereni"

using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // OPCIÓN 1

            char[] frase = new char[31]; 
            char caracter1,caracter2,letraFrase;
            int contCaracteres=0;

            Console.WriteLine("Ingrese una frase caracter por caracter (0 para cortar): ");
            letraFrase = char.Parse(Console.ReadLine());

            while(letraFrase != '0' && contCaracteres < 30){
                frase[contCaracteres]=letraFrase;
                contCaracteres++;
                letraFrase = char.Parse(Console.ReadLine());
            }
            frase[contCaracteres] = '\0';

            Console.WriteLine("Ingrese el caracter que quiere reemplazar: ");
            caracter1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el caracter nuevo: ");
            caracter2 = char.Parse(Console.ReadLine());

            contCaracteres=0;

            while(frase[contCaracteres] != '\0'){
                if(frase[contCaracteres]==caracter1)
                    frase[contCaracteres]=caracter2;
                contCaracteres++;
            }

            contCaracteres=0;

            while(frase[contCaracteres] != '\0'){
                Console.Write(frase[contCaracteres]);
                contCaracteres++;
            }

            // OPCIÓN 2

            // string frase;
            // char caracter1,caracter2;

            // Console.WriteLine("Ingrese la frase: ");
            // frase = Console.ReadLine();

            // Console.WriteLine("Ingrese el caracter que quiere reemplazar: ");
            // caracter1 = char.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el caracter nuevo: ");
            // caracter2 = char.Parse(Console.ReadLine());

            // frase = frase.Replace(caracter1,caracter2);

            // Console.WriteLine(frase);

        }
    }
}




