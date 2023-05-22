Imports System
Imports System.Runtime.InteropServices.JavaScript.JSType

Module Program
    Sub Main(args As String())
        Console.WriteLine("Bienvenido... Presiona una tecla para operar")
        Console.ReadKey()
        'Declaracion de variables
        Dim nombre, apellido As String
        Console.Write("Ingresa tu Nombre: ")
        nombre = Console.ReadLine()
        Console.Write("Ingresa tu Apellido: ")
        apellido = Console.ReadLine()
        Console.Write("Hola " + nombre + " " + apellido)

    End Sub
End Module
