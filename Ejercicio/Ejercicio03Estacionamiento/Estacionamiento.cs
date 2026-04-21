namespace Ejercicio03Estacionamiento
{
    public class Estacionamiento
    {
        public int Capacidad { get; set; }
        public List<Vehiculo> Vehiculos { get; set; }

        public IngresoVehiculo(Vehiculo vehiculo)
        {
            if (Vehiculos.Count < Capacidad)
            {
                Vehiculos.Add(vehiculo);
            }
            else
            {
                Console.WriteLine("No hay lugar disponible.");
            }
        }
        public EgresoVehiculo(string patente)
        {
            var vehiculo = Vehiculos.FirstOrDefault(v => v.Patente == patente);
            if (vehiculo != null)
            {
                Vehiculos.Remove(vehiculo);
            }
            else
            {
                Console.WriteLine("No se encontró un vehículo con esa patente.");
            }
        }
        public bool VerificarPatente(string patente) => Vehiculos.Any(v => v.Patente == patente);
        public int LugaresLibres() => Capacidad - Vehiculos.Count;
    }
}