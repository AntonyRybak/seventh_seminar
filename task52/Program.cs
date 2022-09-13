Console.Clear();
int[,] array = new int[4, 4];
Random rnd = new Random();
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i, j] = rnd.Next(1, 10);
        Console.Write("{0, 3}", array[i, j]);
    }
    Console.WriteLine();
}

for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.WriteLine($"{sum / array.GetLength(0)} ");
}
Console.WriteLine();