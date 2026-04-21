namespace Ejercicio04TiendaDeMusica
{
    public class Instrumento
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }

        public Instrumento(string nombre, string categoria, decimal precio)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }
    }
}