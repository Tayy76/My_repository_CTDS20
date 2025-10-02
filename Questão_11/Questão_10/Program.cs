int ano;
int data;

Console.WriteLine("Em que ano você nasceu?");
ano = int.Parse(Console.ReadLine());

data = 2025 - ano;

if  (data >= 18)
{
    Console.WriteLine("Você tem idade para votar.");
}
else
{
    Console.WriteLine("Você não tem idade para votar.");
}