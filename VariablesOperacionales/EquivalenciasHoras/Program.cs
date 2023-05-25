namespace EquivalenciasHoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const uint minutosPorHora = 60;
            const uint segundosPorHora = 3600;
            const decimal dias = 24.0m;
            uint horas, totalMinutos, totalSegundos;
            decimal TotalDias;
            Console.WriteLine("Conversor de Horas a 'Segundos, Minutos y Dias'");
            Console.Write("Ingrese la cantidad de Horas para calcular la equivalencia en Segundos, Minutos e incluso Dias: ");
            horas = Convert.ToUInt32(Console.ReadLine());
            totalSegundos = horas * segundosPorHora;
            totalMinutos = horas * minutosPorHora;
            TotalDias = Convert.ToDecimal(Math.Round( horas / dias, 3));

            Console.WriteLine($"{horas} Hora(s) son {totalSegundos} segundo(s), {totalMinutos} minuto(s) y {TotalDias} Dia(s)");
        }
    }
}