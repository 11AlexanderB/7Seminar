void FillArray()
{
    Console.WriteLine("Введите количество строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Вывод массива на экран: ");
    double [,] Array = new double [m,n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            Array[i,j] = Math.Round( new Random().Next(-10, 10) + new Random().NextDouble(), 1 );
            Console.Write($"{Array[i,j]}  ");
        }
        Console.WriteLine();
    }
}
FillArray();
