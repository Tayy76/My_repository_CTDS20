using System.Runtime.CompilerServices;

int num1;
int num2;
int num3;
int maior;
int meio;
int menor;

Console.WriteLine("Digite o primeiro número.");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número.");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro número.");
num3 = int.Parse(Console.ReadLine());

if (num1 > num2 && num1 > num3 && num3 < num2)
{
    Console.WriteLine($"Os números são {num3} {num2} {num1}.");
}

if (num1 > num2 && num1 > num3 && num2 < num3)
{
    Console.WriteLine($"Os números são {num2} {num3} {num1}.");
}

if (num3 > num1 && num3 > num1 && num2 < num1)
{
    Console.WriteLine($"Os números são {num2} {num1} {num3}.");
}

if (num2 > num1 && num2 > num3 && num3 < num1)
{
    Console.WriteLine($"Os números são {num3} {num1} {num2}.");
}

if (num2 > num1 && num2 > num3 && num1 < num3)
{
    Console.WriteLine($"Os números são {num1} {num3} {num2}.");
}

if (num3 > num1 && num3 > num2 && num1 < num2)
{
    Console.WriteLine($"Os números são {num1} {num2} {num3}.");
}