namespace EjerciciosNet02.Ejercicio02Gimnasio;
using System.Linq;
public class Gimnasio
{
    public List<Socio> Socios {get; set;} = new List<Socio>();
    public int CapacidadMaxima {get; set;}

    public Gimnasio(int capacidadMaxima)
    {
        CapacidadMaxima = capacidadMaxima;
    }

    public void AgregarSocio(Socio socio)
    {
        if (Socios.Count < CapacidadMaxima)
        {
            Socios.Add(socio);
        }
        else
        {
            Console.WriteLine("No se puede agregar el socio. Capacidad máxima alcanzada.");
        }
    }

    public void DarBajaSocio(Socio socio) => Socios.Remove(socio);

    public void MarcarCuota(Socio socio, bool alDia) => socio.CuotaAlDia = alDia;

    public int CantidadSociosAlDia() => Socios.Count(s => s.CuotaAlDia);
}