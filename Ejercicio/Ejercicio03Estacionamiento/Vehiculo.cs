namespace Ejercicio03Estacionamiento
{
    public class Vehiculo
    {
        public string Dueño { get; set; }
        public string Patente { get; set; }

        public Vehiculo(string dueño, string patente)
        {
            Dueño = dueño;
            Patente = patente;
        }
    }
    
}