/*Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
casas decimais conforme exemplos.
Fórmula da área: area = π . raio2
Considere o valor de π = 3.14159*/

using System.Globalization;


Console.WriteLine("ENTRADA: ");

double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double area = 3.14159 * raio * raio;

Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));