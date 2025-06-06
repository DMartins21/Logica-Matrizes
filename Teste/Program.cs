Console.Write("Qual a ordem da matriz? ");
int n  = int.Parse(Console.ReadLine());
int[,] matriz = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"Elemento {i},{j}: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < matriz.GetLength(0); i++)
{
    int maiorElemento = matriz[i,0];
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        maiorElemento = matriz[i, j] > maiorElemento ? matriz[i, j] : maiorElemento;
    }

    Console.WriteLine(maiorElemento);
}
