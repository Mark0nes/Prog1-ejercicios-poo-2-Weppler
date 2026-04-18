using EjerciciosNet2.Ejercicio02Gimnasio;

internal class Program
{
    static void EjercicioGimnasio()
    {
        Console.WriteLine("Ingrese la capacidad máxima del gimnasio:");
        int capacidadMaxima = Convert.ToInt32(Console.ReadLine()!);
        Gimnasio gimnasio = new Gimnasio(capacidadMaxima);
        bool activo=true;
        while (activo)
        {
            int input;
            Console.WriteLine("Lo que desee realizar:");
            Console.WriteLine("1:Inscribir un socio");
            Console.WriteLine("2:Dar de baja un socio");
            Console.WriteLine("3:Marcar cuota de un socio");
            Console.WriteLine("4:Mostrar cantidad de socios al día");
            Console.WriteLine("Cualquier otra tecla para salir");
            input=Convert.ToInt16(Console.ReadLine()!);

            switch (input)
            {
                case 1:
                    Console.WriteLine("Ingrese el nombre del socio:");
                    string nombre = Console.ReadLine()!;
                    Console.WriteLine("Ingrese el número de socio:");
                    int numeroSocio = Convert.ToInt32(Console.ReadLine()!);
                    Socio socio = new Socio(){Nombre=nombre, NumeroSocio=numeroSocio};
                    gimnasio.AgregarSocio(socio);
                    break;
                case 2:
                    Console.WriteLine("Ingrese el nombre del socio que desea dar de baja:");
                    string eliminar=Console.ReadLine()!;
                    for (int i=0; i < gimnasio.Socios.Count; i++)
                    {
                        if (gimnasio.Socios[i].Nombre == eliminar)
                        {
                            gimnasio.DarBajaSocio(gimnasio.Socios[i]);
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Ingrese el nombre del socio cuya cuota desea marcar:");
                    string marcar = Console.ReadLine()!;
                    for (int i=0; i < gimnasio.Socios.Count; i++)
                    {
                        if (gimnasio.Socios[i].Nombre == marcar)
                        {
                            Console.WriteLine("Ingrese 1 si la cuota está a día, 0 si no:");
                            bool alDia = Convert.ToBoolean(Console.ReadLine()!);
                            gimnasio.MarcarCuota(gimnasio.Socios[i], alDia);
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine($"Cantidad de socios al día: {gimnasio.CantidadSociosAlDia()}");
                    break;
                default:
                    activo=false;
                    break;
            }
        }
    }
}

