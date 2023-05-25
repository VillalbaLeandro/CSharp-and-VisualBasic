namespace GradosFahrenheitCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ºF = (ºC · 1,8) +32
            decimal celsius, fahrenheit;

            Console.WriteLine("Conversion de grados Celsius a Fahrenheit");
            Console.WriteLine("Ingrese cantidad de grados Celsius: ");
            celsius = Convert.ToDecimal(Console.ReadLine().Replace(".",","));
            fahrenheit = (celsius * 1.8m) + 32;
            Console.WriteLine(celsius + " grados celsius son " + fahrenheit + " grados Fahrenheit");
        }
    }
}