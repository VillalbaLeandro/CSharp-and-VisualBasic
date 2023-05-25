Imports System

Module Program
    Sub Main(args As String())
        Const velocidadLuz As UInteger = 300000
        Dim segundos As UInteger
        Dim km, millasNauticas As Decimal
        Console.WriteLine("A la velocidad de la luz")
        Console.WriteLine("Ingrese la Cantidad de Segundos para saber a que distancia viajarias a la velocidad de la luz en ese tiempo: ")
        segundos = Convert.ToUInt32(Console.ReadLine())
        km = segundos * velocidadLuz
        Console.WriteLine("La cantidad de kilometros que viajarias en " & segundos & " a la velocidad de la luz son: " & km)
        millasNauticas = Math.Round(km / 1852, 2)
        Console.WriteLine("Y la cantidad de millas nauticas son: " & millasNauticas)
    End Sub
End Module
