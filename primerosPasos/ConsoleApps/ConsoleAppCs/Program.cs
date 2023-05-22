namespace ConsoleAppCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido... Presiona una tecla para operar");
            Console.ReadKey();
            //Declaracion de variables
            string nombre, apellido;
            Console.Write("Ingresa tu Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingresa tu Apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Hola " + nombre + " " + apellido);

        }

    }
}