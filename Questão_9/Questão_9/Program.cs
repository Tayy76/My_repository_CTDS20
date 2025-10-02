double apple;
double pagar;

Console.WriteLine("Você vai comprar quantas maçãs?");
apple = double.Parse(Console.ReadLine());

if (apple < 12)
{
    pagar = apple * 1.30;
    Console.WriteLine($"Você irá pagar R${pagar:F2}");
}
else
{
    pagar = apple * 1.00;
    Console.WriteLine($"Você irá pagar R${pagar:F2}");
}