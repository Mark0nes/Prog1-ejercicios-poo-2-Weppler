namespace EjerciciosPOO;

static void Main()
{
    Console.Write("Ingrese el numero del ejercicio que desea ejecutar:");
    int input=Convert.ToInt16(Console.ReadLine()!);
    switch (input)
    {
        case 1:
            EjercicioVeterinaria();
            break;
        case 2:
            ;
            break;
        case 3:
            ;
            break;
        default:
            Console.WriteLine("Opcion no valida");
            break;
    }
}
