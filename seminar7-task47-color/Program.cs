//=======================================================
// # 47 Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)
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

// Метод, принимает двумерный массив и массив цветов, печатает разными цветами по столбцам
void Print2DArrayColored(double[,] arr, ConsoleColor[] colors)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // Цветов - 16, индекс цвета берём как остаток от деления на 16, чтобы не выйти за пределы
            Console.ForegroundColor = colors[j % colors.Length];
            Console.Write($"{Math.Round(arr[i, j], 2)} ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// Метод генерации и заполнения массива вещественных чисел
double[,] Fill2DArrayDouble(int rows, int cols, double numMin, double numMax)
{
    // Создаём массив
    double[,] array2D = new double[rows, cols];

    // Тест границ
    if (numMin < numMax)
    {
        // Заполняем массив
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array2D[i, j] = new Random().NextDouble() * (numMax - numMin) + numMin;
            }
        }
    }

    return array2D;
}

// Данные для генерации массива
double numMin = 10;
double numMax = 99;
// Получаем массив консольных цветов
ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

int inputRows = ReadData("Введите количество строк: ");
int inputCols = ReadData("Введите количество столбцов: ");

Console.WriteLine($"Случайный массив вещественных чисел {inputRows}x{inputCols}:");
Print2DArrayColored(Fill2DArrayDouble(inputRows, inputCols, numMin, numMax), colors);