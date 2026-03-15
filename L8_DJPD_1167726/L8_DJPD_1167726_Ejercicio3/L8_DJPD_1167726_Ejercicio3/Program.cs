using System.Numerics;
double total = 0;
int pago = 0;
int clientes = 0;
double ventas = 0;
double descuento1 = 0.05;
double descuento2 = 0.012;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Ingrese el monto de su compra");
    double monto = double.Parse(Console.ReadLine());

    if (monto > 700)
    {
        total = monto - (monto * descuento2);
        clientes++;
       
    }
    else if (monto > 300)
    {
        total = monto - (monto * descuento1);
        clientes++;
    }
    else
    {
        total = monto;
    }
    Console.WriteLine("El total a pagar es de:" + total);

    ventas += total;
}
Console.WriteLine("Los clientes con descuento fueron:" + clientes);
Console.WriteLine("El total de ventas fue del dia fue de:" + ventas);