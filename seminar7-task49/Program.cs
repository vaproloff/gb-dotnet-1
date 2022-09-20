//=======================================================
// # 49 Задайте двумерный массив. Найдите элементы, у которых
// оба индекса чётные, и замените эти элементы на их квадраты.
//=======================================================

// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод, печатает одномерный массив
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Метод генерации и заполнения массива
int[,] Fill2DArray(int rows, int cols, int numMin, int numMax)
{
    // Создаём массив
    int[,] array2D = new int[rows, cols];

    if (numMin < numMax)
    {
        // Заполняем массив
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array2D[i, j] = new Random().Next(numMin, numMax + 1);
            }
        }
    }

    return array2D;
}

// Метод, принимает массив, возвращает массив с квадратами элементов с четными индексами
int[,] SqrEvenIndexElements(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i += 2)
    {
        for (int j = 0; j < arr.GetLength(1); j += 2)
        {
            arr[i, j] = (int)Math.Pow(arr[i, j], 2);
        }
    }

    return arr;
}

// Данные для генерации массива
int numMin = 10;
int numMax = 99;

int rows = ReadData("Введите количество строк: ");
int cols = ReadData("Введите количество столбцов: ");

int[,] array2D = Fill2DArray(rows, cols, numMin, numMax);

Console.WriteLine($"Случайный массив {rows}x{cols}:");
Print2DArray(array2D);
Console.WriteLine();

Console.WriteLine($"Изменённый массив {rows}x{cols}:");
Print2DArray(SqrEvenIndexElements(array2D));