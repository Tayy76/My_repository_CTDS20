int numero;
int resultado;

Console.WriteLine("Digite um número, por favor.");

numero = int.Parse(Console.ReadLine());

resultado = numero - 1;

Console.WriteLine($"O antecessor de {numero} é {resultado}");