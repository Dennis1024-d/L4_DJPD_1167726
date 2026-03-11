// See https://aka.ms/new-console-template for more information
//1 Declaracion de variables 
using System.Globalization;
string nombre = "Link";
int nivel = 50;
float puntos_de_vida = 10.5F;
bool es_un_jefe = false;
Console.WriteLine(nombre + " " + nivel + "" + puntos_de_vida + " " + es_un_jefe);
Console.ReadLine();

//2. Concersion Implicita
int numeroEntero = 1500;
long numerolargo;
numerolargo = numeroEntero;
Console.WriteLine(numerolargo);
Console.ReadLine();
double numeroDecimal = numerolargo;
Console.WriteLine("Valor de numeroDecimal: " + numeroDecimal);

//3. Conversion Explicita 
double precioExtra = 45.89;
int precioRedondeado;
precioRedondeado = (int)precioExtra;
Console.WriteLine(precioExtra);

//4. Metodo Parce 
Console.WriteLine("Ingresar un numero:");
string entradaUsuario = Console.ReadLine();
int numero = int.Parse(entradaUsuario);
Console.WriteLine(numero + 5);

//5 clase convert
string valorTexto = "True";
bool ValorBooleano = Convert.ToBoolean(valorTexto);
string ValorDecimal = "25.5";
double ValorDouble = Convert.ToDouble(ValorDecimal);
Console.WriteLine(ValorBooleano);
Console.WriteLine(ValorDecimal);

//6 conversion a texto (.toString)
double pi = 3.14159265;
string cadena = pi.ToString("F2");
Console.WriteLine(cadena);

//7. Reto final-Calculadora de IVA
Console.WriteLine("Cual es el precio del producto");
string precio = Console.ReadLine();
double Precioo = Convert.ToDouble(precio);
double iva = Precioo * 0.21;
double total = Precioo + iva;
int totalFinal = (int)total;
Console.WriteLine("El Total a pagar es:" + totalFinal);

