int[,] FillArray()
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

int[,]Mas = FillArray();
void FindElement()
{
    Console.WriteLine("Введите координату строки: ");
    int Rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коррдинату столбца: ");
    int Columns = Convert.ToInt32(Console.ReadLine());

    if(Rows < Mas.GetLength(0) && Columns < Mas.GetLength(1))
    {
        Console.WriteLine($"В данной ячейке хранится элемент: {Mas[Rows,Columns]}");
    }
    
    else Console.WriteLine($"Элемента с такими координатами не существует");
    
}
FindElement(); 