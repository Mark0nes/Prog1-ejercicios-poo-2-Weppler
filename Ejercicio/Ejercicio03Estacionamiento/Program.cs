using Ejercicio03Estacionamiento;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la capacidad del estacionamiento:");
        int capacidad = Convert.ToInt32(Console.ReadLine()!);
        Estacionamiento estacionamiento = new Estacionamiento(){Capacidad=capacidad, Vehiculos=new List<Vehiculo>()};
        bool activo=true;
        while (activo)
        {
            int input;
            Console.WriteLine("Lo que desee realizar:");
            Console.WriteLine("1:Ingresar un vehículo");
            Console.WriteLine("2:Retirar un vehículo");
            Console.WriteLine("3:Verificar si un vehículo está en el estacionamiento");
            Console.WriteLine("4:Mostrar lugares libres");
            Console.WriteLine("Cualquier otra tecla para salir");
            input=Convert.ToInt16(Console.ReadLine()!);

            switch (input)
            {
                case 1:
                    Console.WriteLine("Ingrese el nombre del dueño del vehículo:");
                    string dueño = Console.ReadLine()!;
                    Console.WriteLine("Ingrese la patente del vehículo:");
                    string patente = Console.ReadLine()!;
                    Vehiculo vehiculo = new Vehiculo(dueño, patente);
                    estacionamiento.IngresoVehiculo(vehiculo);
                    break;
                case 2:
                    Console.WriteLine("Ingrese la patente del vehículo que desea retirar:");
                    string eliminar=Console.ReadLine()!;
                    estacionamiento.EgresoVehiculo(eliminar);
                    break;
                case 3:
                    Console.WriteLine("Ingrese la patente del vehículo que desea verificar:");
                    string verificar = Console.ReadLine()!;
                    if (estacionamiento.VerificarPatente(verificar))
                    {
                        Console.WriteLine("El vehículo está en el estacionamiento.");
                    }
                    else
                    {
                        Console.WriteLine("El vehículo no está en el estacionamiento.");
                    }
                    break;
                case 4:
                    Console.WriteLine($"Lugares libres: {estacionamiento.LugaresLibres()}");
                    break;
                default:
                    activo=false;
                    break;
            }
        }
    }
}