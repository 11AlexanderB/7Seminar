int [,] FillArray()
{
    Console.WriteLine("Введите количество строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Вывод массива на экран:");
    int [,] Array = new int [m,n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            Array[i,j] = new Random().Next(1, 10);
            Console.Write($"{Array[i,j]}    ");
        }
        Console.WriteLine();   
    }   
    return Array;
}

int [,] Mas = FillArray();
void GetAverage()
{
    double Average = 0;

    for(int j = 0; j < Mas.GetLength(1); j++)
    {
        double Sum = 0;

        for(int i = 0; i < Mas.GetLength(0); i++)
        {
            Sum = Sum+ Mas[i,j];   
        }
        Average = Math.Round( Sum / Mas.GetLength(0), 1);
        Console.Write($"{Average}  ");
    }
       
}
Console.WriteLine("Среднее арифметическое каждого столбца: ");
GetAverage();
    
