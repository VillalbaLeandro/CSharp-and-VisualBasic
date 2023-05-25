Imports System

Module Program
    Sub Main(args As String())
        '//ºF = (ºC · 1,8) +32
        Dim celsius, fahrenheit As Decimal
        Console.WriteLine("Conversion de grados Celsius a Fahrenheit")
        Console.WriteLine("Ingrese cantidad de grados Celsius: ")
        celsius = Convert.ToDecimal(Console.ReadLine().Replace(".", ","))
        fahrenheit = (celsius * 1.8) + 32
        Console.WriteLine(celsius + " grados celsius son " + fahrenheit + " grados Fahrenheit")
    End Sub
End Module
