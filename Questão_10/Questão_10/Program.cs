double nota1;
double nota2;

Console.WriteLine("Digite a sua primeira nota.");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a sua segunda nota.");
nota2 = double.Parse(Console.ReadLine());

if (nota1 + nota2 > 6)
{
    Console.WriteLine("Você foi aprovado.");
}
else
{
    Console.WriteLine("Você foi reprovado.");
}