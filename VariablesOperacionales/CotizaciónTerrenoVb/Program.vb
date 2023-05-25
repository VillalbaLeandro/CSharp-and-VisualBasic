Imports System

Module Program
    Sub Main(args As String())
        Dim costoMetroCuadrado, costo, ancho, longitud As Decimal
        Console.WriteLine("Calculadora de costo de terreno!")
        Console.Write("Ingrese Ancho del terreno: ")
        ancho = Convert.ToDecimal(Console.ReadLine())
        Console.Write("Ingrese Longitud del terreno: ")
        longitud = Convert.ToDecimal(Console.ReadLine())
        Console.Write("Costo en Dolares: ")
        costoMetroCuadrado = Convert.ToDecimal(Console.ReadLine())
        'Formula Area = base x altura ... Area * precio
        costo = ancho * longitud * costoMetroCuadrado

        Console.WriteLine($"El costo de terreno de {ancho}mts de ancho por {longitud}mts de longitud a {costoMetroCuadrado} dolar(es) por metro cuadrado es: USD ${costo}")

    End Sub
End Module
