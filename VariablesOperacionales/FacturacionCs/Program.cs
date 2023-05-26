namespace FacturacionCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal precioVenta, costo, montoUtilidad, precioSinIva;
            byte porcentajeUtilidad;
            const decimal iva = 0.21m;
            Console.WriteLine("Sistema Facturacion");
            Console.Write("Ingrese costo del producto: ");
            costo = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingrese El porcentaje de utilidad: ");
            porcentajeUtilidad = Convert.ToByte(Console.ReadLine());

            montoUtilidad = (costo * porcentajeUtilidad) / 100;
            precioSinIva = costo + montoUtilidad;
            precioVenta = costo * iva;
            Console.WriteLine("Monto de utilidad es: " + montoUtilidad);
            Console.WriteLine("El precio final del producto es: " + precioVenta);

        }

    }
}