Console.WriteLine("Ingrese el número de filas:");
int fila = int.Parse(Console.ReadLine());

for (int i = 1; i <= fila; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}