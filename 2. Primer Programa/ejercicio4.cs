// 4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. 
// Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.


using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float totalPorEmp,com,sueldo;
            const float fijo = 15000;
            const float porcentajeCom = 5;

            Console.WriteLine("Ingrese el total facturado por empleado: ");
            totalPorEmp = float.Parse(Console.ReadLine());
            com = porcentajeCom * totalPorEmp/100;
            // com = totalPorEmp * 0.05;
            sueldo = fijo+com;
            Console.WriteLine("El sueldo es de $" + sueldo);
        }
    }
}
