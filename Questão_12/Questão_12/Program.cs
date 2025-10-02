using System;

int valor;
int valor2;

Console.WriteLine("Digite o primeiro número.");
valor = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número.");
valor2 = int.Parse(Console.ReadLine());

if (valor > valor2)
{
    Console.WriteLine($"{valor} é maior que {valor2}");
}
else
{
    Console.WriteLine($"{valor2} é maior que {valor}");
}