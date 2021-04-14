using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2AnalisisGuia12
{
class Program
{
struct ejemplo
{
public String Name;
public String Titulo;
public Double Fichero;
public Double Duracion;
public void Registrar(string n, string t, Double d, Double f)
{
Name = n;
Titulo = t;
Fichero = f;
Duracion = d;
}
}
static void Main(string[] args)
{
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.Title = "Registro de canciones.";

int tan;

Console.WriteLine("Digite el número de canciones a registrar: ");
tan = int.Parse(Console.ReadLine());
ejemplo[] E = new ejemplo[tan];

Console.WriteLine();


for (int i = 0; i < tan; i++)
{
Console.Write("Ingrese nombre del artista: ");
String n = Console.ReadLine();
Console.Write("Ingrese nombre del título: ");
String t = Console.ReadLine();
Console.Write("Ingrese duración (en segundos): ");
Double d = Double.Parse(Console.ReadLine());
Console.Write("Ingrese tamaño del fichero (en KB): ");
Double f = Double.Parse(Console.ReadLine());
Console.WriteLine();

E[i].Registrar(n, t, d, f);
}

Console.Clear();
Console.WriteLine("Información ingresada:");
Console.WriteLine("------------------------");

for (int i = 0; i < tan; i++)
{
Console.WriteLine("Nombre: " + E[i].Name);
Console.WriteLine("Titulo: " + E[i].Titulo);
Console.WriteLine("Duración: " + E[i].Duracion);
Console.WriteLine("Tamaño del fichero: " + E[i].Fichero);
Console.WriteLine("----------------------");
}

Console.ReadKey();
}
}
}

