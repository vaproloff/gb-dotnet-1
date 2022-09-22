//=======================================================
// # 52 Задайте двумерный массив из целых чисел. Найдите
// среднее арифметическое элементов в каждом столбце.
// * Дополнительно вывести среднее арифметическое
// по диагоналям и диагональ выделить разным цветом.
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

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
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

// Метод, печатает одномерный массив разными цветами
void Print1DArrayColored(double[] arr, ConsoleColor[] colors)
{
    string arrString = String.Empty;

    // В цикле меняем цвет шрифта, печатаем, сбрасываем цвет
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = colors[i % colors.Length];
        Console.Write($"{arr[i]} ");
        Console.ResetColor();
    }
}

// Метод, печатает двумерный массив с диагоналями разных цветов
void Print2DArrayColored(int[,] arr, ConsoleColor[] colors)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // Вычисляем индекс цвета - номер диагонали в двумерном массиве
            Console.ForegroundColor = colors[(j - i + (arr.GetLength(0) - 1)) % colors.Length];
            Console.Write($"{arr[i, j]} ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// Метод, принимает двумерный массив, возвращает одномерный массив средних арифметических по диагоналям
double[] CalcAvrgDiagonals(int[,] arr)
{
    // Создаём одномерный массив с длиной - количеством диагоналей
    double[] diagAverages = new double[arr.GetLength(1) + arr.GetLength(0) - 1];

    // В циклах проходим по двумерному массиву, суммируя элементы по диагоналям
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // Вычисляем индекс - номер диагонали, накапливаем сумму
            diagAverages[j - i + (arr.GetLength(0) - 1)] += arr[i, j];
        }
    }
    // Возвращаем массив, разделяя каждый элемент на количество элементов в диагонали
    return DivideArrDiagonals(diagAverages, arr.GetLength(0));
}

// Метод, принимает массив и макс. кол-во элементов в диагонали, делит каждый элемент на нужное количество
double[] DivideArrDiagonals(double[] arr, int maxDivider)
{
    for (int i = 0; i < arr.Length; i++)
    {
        // Вычисляем количество элементов в определённой диагонали, делим элемент массива на это количество
        int diagSize = Math.Min(Math.Min(i + 1, maxDivider), arr.Length - i);
        arr[i] = Math.Round(arr[i] / diagSize, 2);
    }

    return arr;
}

// Данные для генерации массива
int numMin = 10;
int numMax = 99;
// Получаем массив консольных цветов
ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

int inputRows = ReadData("Введите количество строк: ");
int inputCols = ReadData("Введите количество столбцов: ");
int[,] array2D = Fill2DArray(inputRows, inputCols, numMin, numMax);
PrintResult($"Случайный массив целых чисел {inputRows}x{inputCols}:");
Print2DArrayColored(array2D, colors);
PrintResult("Средние арифметические по диагоналям:");
Print1DArrayColored(CalcAvrgDiagonals(array2D), colors);