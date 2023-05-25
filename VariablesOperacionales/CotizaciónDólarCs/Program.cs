namespace CotizaciónDólarCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal dolares, pesos, total;
            Console.WriteLine("Bienvenido a Cambios Mazza! :D");
            Console.WriteLine("Sistema de cambios");
            Console.Write("Por favor ingrese la cantidad de pesos para realizar la convercion a dolares: ");
            pesos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la cotizacion actual del dolar por Peso Argentino: ");
            dolares = Convert.ToInt32(Console.ReadLine());
            total = pesos * dolares;
            Console.WriteLine($"El monto en pesos ingresado es de: ${pesos} peso(s) y son USD ${dolares} ");


        }
    }
}