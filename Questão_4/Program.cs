int idade, data;

Console.WriteLine("Qual ano que você nasceu?");
idade = int.Parse(Console.ReadLine());
data = (2025 - idade) * 365;
Console.WriteLine($"Você tem {data} dias de vida.");