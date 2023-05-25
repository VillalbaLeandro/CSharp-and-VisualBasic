namespace CotizacionTerrenoCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal costoMetroCuadrado, costo, ancho, longitud;
            Console.WriteLine("Calculadora de costo de terreno!");
            Console.Write("Ingrese Ancho del terreno: ");
            ancho = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingrese Longitud del terreno: ");
            longitud = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Costo en Dolares: ");
            costoMetroCuadrado = Convert.ToDecimal(Console.ReadLine());
            //'Formula Area = base x altura ... Area * precio
            costo = ancho * longitud * costoMetroCuadrado;

            Console.WriteLine($"El costo de terreno de {ancho}mts de ancho por {longitud}mts de longitud a {costoMetroCuadrado} dolar(es) por metro cuadrado es: USD ${costo}");
        }
    }
}