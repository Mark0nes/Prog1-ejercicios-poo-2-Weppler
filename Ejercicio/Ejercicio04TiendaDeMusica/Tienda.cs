namespace Ejercicio04TiendaDeMusica
{
    public class Tienda
    {
        public List<Instrumento> Instrumentos { get; set; }

        public AgregarInstrumento(Instrumento instrumento) => Instrumentos.Add(instrumento);
        public RegistrarVenta(string nombre) {
            var instrumento = Instrumentos.FirstOrDefault(i => i.Nombre == nombre);
            if (instrumento != null)
            {
                Instrumentos.Remove(instrumento);
                Console.WriteLine($"Venta registrada: {instrumento.Nombre} por ${instrumento.Precio}");
            }
            else
            {
                Console.WriteLine("El instrumento no está en stock.");
            }
        }
        public List<Instrumento> BuscarInstrumento(string categoria) => Instrumentos.Where(i => i.Categoria == categoria).ToList();
        public MostrarPrecioStock() => Console.WriteLine($"Precio total del stock: {Instrumentos.Sum(i => i.Precio)}");
    }
}