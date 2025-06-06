Console.Write("Quantidade de linhas:");
int l = int.Parse(Console.ReadLine());
Console.Write("Quantidade de colunas:");
int c = int.Parse(Console.ReadLine());

int [,] matriz = new int [l,c];

for (int i = 0; i < l; i++)
{
    Console.WriteLine($"Digite o valor da {i+1} linha:");
    for (int j = 0; j < c; j++)
    {
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Vetor:");
for (int i = 0; i < l; i++)
{
    int vetor = 0;
    for (int j = 0; j < c; j++)
    {
        vetor += matriz[i, j];
    }
    Console.WriteLine(vetor);
}