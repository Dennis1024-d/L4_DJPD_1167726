Console.WriteLine("Ingrese un número entero:");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("Seleccione una opción:");
Console.WriteLine("1. Mostrar los números desde el número ingresado hasta 1");
Console.WriteLine("2. Mostrar los múltiplos de 3 hasta el número ingresado");
Console.WriteLine("3. Mostrar los múltiplos de 5 hasta el número ingresado");

int op = int.Parse(Console.ReadLine());

switch (op)
{
    case 1:
        for (int i = numero; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
        break;

    case 2:
        for (int i = 1; i <= numero; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
        break;

    case 3:
        for (int i = 1; i <= numero; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }
        break;

    default:
        Console.WriteLine("Opción no válida");
        break;
}