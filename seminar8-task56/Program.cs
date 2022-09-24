//=======================================================
// # 56 Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
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

// Метод, печатает двумерный массив
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

// Метод, принимает двумерный массив, возвращает номер строки с наименьшей суммой элементов
int FindMinRowIndex(int[,] arr)
{
    // Вводим переменные индексом строки с минимальной суммой и самой суммой
    int minRowSum = int.MaxValue;
    int minRowIndex = -1;

    // В циклах считаем сумму элементов строки, сравниваем с минимальной, обновляем переменные при необходимости
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int currentSum = 0;

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            currentSum += arr[i, j];
        }

        if (currentSum < minRowSum)
        {
            minRowSum = currentSum;
            minRowIndex = i;
        }
    }

    return minRowIndex + 1;
}

// Данные для генерации массива
int numMin = 10;
int numMax = 99;

int inputRows = ReadData("Введите количество строк: ");
int inputCols = ReadData("Введите количество столбцов: ");
int[,] array2D = Fill2DArray(inputRows, inputCols, numMin, numMax);
PrintResult($"Случайный массив целых чисел {inputRows}x{inputCols}:");
Print2DArray(array2D);
Console.WriteLine();
PrintResult($"{FindMinRowIndex(array2D)}-я - строка с наименьшей суммой элементов");