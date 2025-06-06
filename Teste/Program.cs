Console.Write("Quantidade de linhas: ");
int linhas = int.Parse(Console.ReadLine());
Console.Write("Quantidade de colunas: ");
int colunas = int.Parse(Console.ReadLine());

int count = 0;

int [,] matriz = new int[linhas, colunas];

for (int i = 0; i < linhas; i++)
{
    for (int j = 0; j < colunas; j++)
    {
        Console.Write($"Elemento [{i}, {j}]: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

foreach (var elemento in matriz)
{
    if (elemento < 0) Console.WriteLine(elemento);
}
