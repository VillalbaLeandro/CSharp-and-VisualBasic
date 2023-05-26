namespace SumaPromedioCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const byte totalNum = 4;
            decimal num1, num2, num3, num4, promedio;
            Console.WriteLine("Bienvenido al Sistema de Promedio");
            Console.WriteLine("A continuacion se le pedira que ingrese numeros para realizar el promedio");
            Console.Write("Ingrese numero Nº 1: ");
            num1 = Convert.ToDecimal(Console.ReadLine().Replace(".", ","));
            Console.Write("Ingrese numero Nº 2: ");
            num2 = Convert.ToDecimal(Console.ReadLine().Replace(".", ","));
            Console.Write("Ingrese numero Nº 3: ");
            num3 = Convert.ToDecimal(Console.ReadLine().Replace(".", ","));
            Console.Write("Ingrese numero Nº 4: ");
            num4 = Convert.ToDecimal(Console.ReadLine().Replace(".", ","));

            promedio = (num1 + num2 + num3 + num4) / totalNum;
            Console.Write($"El promedio de las 4 notas ingresadas es: {promedio}");
        }
    }
}