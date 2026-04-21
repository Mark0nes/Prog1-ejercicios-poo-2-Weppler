using Ejercicio04TiendaDeMusica;

internal class Program
{
    private static void Main(string[] args)
    {
        var tienda = new Tienda { Instrumentos = new List<Instrumento>() };
        bool activo = true;
        while (activo)
        {
            Console.WriteLine("Lo que desee realizar:");
            Console.WriteLine("1:Agregar un instrumento");
            Console.WriteLine("2:Registrar una venta");
            Console.WriteLine("3:Buscar un instrumento por categoría");
            Console.WriteLine("4:Mostrar el precio total del stock");
            Console.WriteLine("Cualquier otra tecla para salir");
            int input = Convert.ToInt16(Console.ReadLine()!);

            switch (input)
            {
                case 1:
                    Console.WriteLine("Ingrese el nombre del instrumento:");
                    string nombre = Console.ReadLine()!;
                    Console.WriteLine("Ingrese la categoría del instrumento:");
                    string categoria = Console.ReadLine()!;
                    Console.WriteLine("Ingrese el precio del instrumento:");
                    double precio = Convert.ToDouble(Console.ReadLine()!);
                    Instrumento instrumento = new Instrumento(nombre, categoria, precio);
                    tienda.AgregarInstrumento(instrumento);
                    break;
                case 2:
                    Console.WriteLine("Ingrese el nombre del instrumento vendido:");
                    string vendido = Console.ReadLine()!;
                    tienda.RegistrarVenta(vendido);
                    
                case 3:
                    Console.WriteLine("Ingrese la categoría a buscar:");
                    string buscarCategoria = Console.ReadLine()!;
                    var encontrados = tienda.BuscarInstrumento(buscarCategoria);
                    if (encontrados.Count > 0)
                    {
                        Console.WriteLine("Instrumentos encontrados:");
                        foreach (var i in encontrados)
                        {
                            Console.WriteLine($"- {i.Nombre} (${i.Precio})");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se encontraron instrumentos en esa categoría.");
                    }
                    break;
                case 4:
                    tienda.MostrarPrecioStock();
                    break;
                default:
                    activo = false;
                    break;
            }
        }
    }
}