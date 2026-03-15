//Ejercio While
string nombre = "Dennis Jossue Palacios Diaz";
int carnet = 1167726;
int indice = 1;

Console.WriteLine("Nombre:" + nombre + "Carnet:" + carnet.ToString());

while (indice <= 20)
{
    if (indice % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }

    Console.WriteLine(indice);

    indice = indice + 1;
}
Console.ForegroundColor = ConsoleColor.White;
Console.ReadLine();

//Ejercicio DO-While
Console.WriteLine("----------------------------------------");
int numero;
int no = 1;
Console.WriteLine("Ingrese un numero positivo y entero");
numero = int.Parse(Console.ReadLine());

Console.WriteLine("Los divisores son:");

do
{
    if (numero % no == 0)
    {
        Console.WriteLine(no);

    }
    no++;
} while (no <= numero);

//Ejercicio for
Console.WriteLine("----------------------------------------");
int n;
int a = 0;
int b = 1;

Console.WriteLine("Ingrese el numero para la serie de Fibonacci");
n = int.Parse(Console.ReadLine());

Console.WriteLine("Serie de Fibonacci:");

for (int i = 0; i < n; i++)
{
    Console.WriteLine(a);

    int siguiente = a + b;
    a = b;
    b = siguiente;
}

//Ciclo anidado
Console.WriteLine("----------------------------------------");
int nu = 1;

for (int numero1 = 1; numero1 <= 12; numero1++)
{
    Console.WriteLine("Tabla del " + nu++);

    for (int numero2 = 1; numero2 <= 10; numero2++)
    {
        int resultado = numero1 * numero2;
        Console.WriteLine(numero1 + " x " + numero2 + " = " + resultado);
    }

    Console.WriteLine();
}

Console.ReadLine();