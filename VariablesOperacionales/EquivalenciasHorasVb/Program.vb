Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Const minutosPorHora As UInteger = 60
        Const segundosPorHora As UInteger = 3600
        Const dias As Decimal = 24.0
        Dim horas, totalMinutos, totalSegundos As UInteger
        Dim TotalDias As Decimal
        Console.WriteLine("Conversor de Horas a 'Segundos, Minutos y Dias'")
        Console.Write("Ingrese la cantidad de Horas para calcular la equivalencia en Segundos, Minutos e incluso Dias: ")
        horas = Convert.ToUInt32(Console.ReadLine())
        totalSegundos = horas * segundosPorHora
        totalMinutos = horas * minutosPorHora
        TotalDias = Convert.ToDecimal(Math.Round(horas / dias, 3))

        Console.WriteLine($"{horas} Hora(s) son {totalSegundos} segundo(s), {totalMinutos} minuto(s) y {TotalDias} Dia(s)")
    End Sub
End Module
