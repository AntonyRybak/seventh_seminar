Console.Clear();
double[,] array = new double[3, 4];
 
Random random = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i, j] = random.NextDouble() * 10 -1;
        Console.Write("{0,1:F2}   ", array[i, j]);
    }
    Console.WriteLine();
}