Console.Clear();
int[,] array = new int[4, 4];
Random rnd = new Random();
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++) 
    {
        array[i, j] = rnd.Next(1, 10);
        Console.Write("{0, 3}", array[i,j]);
    }
    Console.WriteLine();
}
Console.WriteLine("Введите номер строки для поиска элемента ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца для поиска элемента ");
int columns = int.Parse(Console.ReadLine());

if (rows < 0 | rows > array.GetLength(0) - 1 | columns < 0 | columns > array.GetLength(1) - 1){
    Console.WriteLine("Такого элемента нет ");
}
else Console.WriteLine("Значение элемента массива = {0}", array[rows,columns]);


