// See https://aka.ms/new-console-template for more information
using System.Globalization;

int HORAS = int.Parse(Console.ReadLine());
int VALOR = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
int SALARIO = HORAS * VALOR;
Console.WriteLine("SALARIO = U$ " + SALARIO.ToString("F2",CultureInfo.InvariantCulture));

