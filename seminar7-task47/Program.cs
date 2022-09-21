//=======================================================
// # 47 Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
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

// Метод, печатает двумерный массив вещественных чисел
void Print2DArrayDouble(double[,] arr)
{
    // В циклах проходим по массиву, печатаем в консоль элементы, разделяя абзацем
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            Console.Write($"{Math.Round(arr[i, j], 2)}; ");
        }

        Console.WriteLine($"{Math.Round(arr[i, arr.GetLength(1) - 1], 2)}");
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

int inputRows = ReadData("Введите количество строк: ");
int inputCols = ReadData("Введите количество столбцов: ");

Console.WriteLine($"Случайный массив вещественных чисел {inputRows}x{inputCols}:");
Print2DArrayDouble(Fill2DArrayDouble(inputRows, inputCols, numMin, numMax));