int valor;

Console.WriteLine("Digite um número.");
valor = int.Parse(Console.ReadLine());

if (valor > 0)
{
    Console.WriteLine("Seu número é positivo.");
}
else
{
    Console.WriteLine("Seu número é negativo.");
}