int Base, Altura;

Console.WriteLine("Digite a base do retângulo.");
Base = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a altura do retângulo.");
Altura = int.Parse(Console.ReadLine());

int area = Base * Altura;

Console.WriteLine($"A área do retângulo é {area}");