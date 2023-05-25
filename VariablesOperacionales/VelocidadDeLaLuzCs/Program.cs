namespace VelocidadDeLaLuzCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const uint velocidadLuz = 300000;
            uint segundos;
            decimal km, millasNauticas;

            Console.WriteLine("A la velocidad de la luz");
            Console.WriteLine("Ingrese la Cantidad de Segundos para saber a que distancia viajarias a la velocidad de la luz en ese tiempo: ");
            segundos = Convert.ToUInt32(Console.ReadLine());
            km = segundos * velocidadLuz;
            Console.WriteLine("La cantidad de kilometros que viajarias en " + segundos + " a la velocidad de la luz son: " + km);
            millasNauticas = Math.Round( km / 1852, 2);
            Console.WriteLine("Y la cantidad de millas nauticas son: " + millasNauticas);


        }
    }
}