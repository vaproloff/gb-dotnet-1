//=======================================================
// # 46 Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
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

ConsoleColor[] colors = new ConsoleColor[] {
    ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
    ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
    ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
    ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
    ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
    ConsoleColor.Yellow
};

// Метод, печатает одномерный массив
void Print2DArrayColored(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = colors[new Random().Next(0, 16)];
            Console.Write($"{arr[i, j]} ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// Метод генерации и заполнения массива
int[,] Fill2DArray(int rows, int cols, int numMin, int numMax)
{
    // Создаём массив
    int[,] array2D = new int[rows, cols];

    // Тест границ
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

// Данные для генерации массива
int numMin = 10;
int numMax = 99;

int rows = ReadData("Введите количество строк: ");
int cols = ReadData("Введите количество столбцов: ");

Console.WriteLine($"Случайный массив {rows}x{cols}:");
Print2DArrayColored(Fill2DArray(rows, cols, numMin, numMax));