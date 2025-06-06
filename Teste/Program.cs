Console.WriteLine("Qual a ordem da matriz?");
int n = int.Parse(Console.ReadLine());
int[,] matriz = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.WriteLine($"Elemento {i}, {j}:");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Matriz Completa:");
foreach (var elemento in matriz)
{
    Console.WriteLine(elemento);
}

Console.WriteLine("Diagonal Principal:");
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"{matriz[i, i]}");
}

int x = 0;

foreach (var elemento in matriz)
{
    if(elemento < 0)  x++;
}

/*for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        int negativos = matriz[i, j];
        if (negativos < 0)
        {
            x++;
        }
    }
}
*/
Console.WriteLine($"Quantidade de negativos: {x}");