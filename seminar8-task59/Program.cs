//=======================================================
// # 59 Задайте двумерный массив из целых чисел. Напишите
// программу, которая удалит строку и столбец, на пересечении
// которых расположен наименьший элемент массива.
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

// Метод, принимает двумерный массив, возвращает индексы минимального элемента массива
int[] FindMinElement(int[,] arr)
{
    int minElement = arr[0, 0];
    int[] minElementIndex = new int[2];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < minElement)
            {
                minElement = arr[i, j];
                minElementIndex[0] = i;
                minElementIndex[1] = j;
            }
        }
    }

    return minElementIndex;
}

// Метод, удаляет строку и столбец с минимальным элементом двумерного массива
int[,] RemoveMinRowCol(int[,] arr, int minRow, int minCol)
{
    int[,] newArray = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int k = 0;
    int m = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i != minRow)
        {
            m = 0;

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j != minCol)
                {
                    newArray[k, m] = arr[i, j];
                    m++;
                }
            }

            k++;
        }

    }

    return newArray;
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

int[] minElementIndex = FindMinElement(array2D);
PrintResult($"Новый массив:");
Print2DArray(RemoveMinRowCol(array2D, minElementIndex[0], minElementIndex[1]));