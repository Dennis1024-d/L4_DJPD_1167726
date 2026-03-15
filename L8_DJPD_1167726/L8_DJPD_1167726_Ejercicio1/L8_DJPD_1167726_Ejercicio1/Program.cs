using static System.Runtime.InteropServices.JavaScript.JSType;
int numero;
int mayor = 0;
int menor = 0;
int suma = 0;

for (int i = 0; i < 20; i++)
{
    Console.WriteLine("Ingrese el numero 20 numeros");
    numero = int.Parse(Console.ReadLine());

    if (i == 0)
    {
        mayor = numero;
        menor = numero;
    }

    if (numero > mayor)
    {
        mayor = numero;
    }

    else if (numero < menor)
    {
        menor = numero;
    }

    suma += numero;
}

double promedio = (double)suma / 20;

Console.WriteLine("El numero mayor es: " + mayor);
Console.WriteLine("El Numero menor es: " + menor);
Console.WriteLine("El Promedio es: " + promedio);
    
