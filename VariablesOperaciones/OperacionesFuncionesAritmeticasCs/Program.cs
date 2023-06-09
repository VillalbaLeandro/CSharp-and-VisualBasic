﻿namespace OperacionesFuncionesAritmeticasCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //contador o incrementador
            ushort contador = 0;
            Console.WriteLine(++contador);
            Console.WriteLine(++contador);
            Console.WriteLine(++contador);
            //acumulador
            uint acumulador = 0;
            acumulador += 20;
            Console.WriteLine(acumulador);
            acumulador += 10;
            Console.WriteLine(acumulador);
            acumulador += 25;
            Console.WriteLine(acumulador);
            //division
            Console.WriteLine(25 / 10);
            Console.WriteLine(Math.Truncate( 25.0 / 10));
            Console.WriteLine(25 % 10);
            //exponenciacion
            ushort r = 5;
            r *= r;
            Console.WriteLine(r);
            Console.WriteLine(Math.Pow(5,5));
            //conversion
            int a = 2147483647;
            long b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            //CASTING
            double c = 1234.5;
            int d;
            d = (int)c;
            Console.WriteLine(d);
            Console.WriteLine("incrementador");
            a = 4;
            b = 10;
            Console.WriteLine(a++);
            Console.WriteLine(++a);
        }
    }
}