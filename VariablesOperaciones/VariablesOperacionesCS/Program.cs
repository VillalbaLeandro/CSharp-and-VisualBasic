﻿namespace VariablesOperacionesCS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte horasTrabajadas;
            ushort valorHora;
            decimal descuento, sueldo;
            valorHora = 500;
            
            Console.Write("Ingrese la cantidad de horas trabajadas: ");
            horasTrabajadas = Convert.ToByte( Console.ReadLine() );
            Console.Write("Ingrese el descuento (negativo): ");
            descuento = Convert.ToDecimal(Console.ReadLine());
            sueldo =Convert.ToUInt32(valorHora) * horasTrabajadas;
            Console.WriteLine("El sueldo bruto es: " + sueldo);
            sueldo += sueldo * descuento / 100;
            Console.WriteLine("El sueldo total es: " + sueldo);

        }
    }
}