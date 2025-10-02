int N;
int num = 0;
int valor = 0;

Console.WriteLine("Digite um valor.");
N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    num++;
    valor = num;
    Console.WriteLine(valor);
}
