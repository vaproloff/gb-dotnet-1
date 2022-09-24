//=======================================================
// # 54 Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
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

// Альтарнативное решение. Реализация метода подсчёта для решения данной задачи.
int[,] SortArrayRowsCount(int[,] arr, int minElement, int maxElement)
{
    // Создаём массив массивов, подсчитываем в каждом подмассиве элементы по строкам
    int[][] countArr = new int[arr.GetLength(0)][];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        countArr[i] = new int[maxElement - minElement + 1];
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            countArr[i][arr[i, j] - minElement]++;
        }
    }

    return FillSortedArray(countArr, arr.GetLength(0), arr.GetLength(1), minElement);
}

int[,] FillSortedArray(int[][] countArr, int rows, int cols, int corrDelta)
{
    int[,] sortedArr = new int[rows, cols];
    // Заполняем строки основного массива , но по массиву подсчёта идём в обратном направлении для сортировки по убыванию
    for (int i = 0; i < rows; i++)
    {
        int k = 0;
        for (int j = countArr[i].Length - 1; j >= 0; j--)
        {
            while (countArr[i][j] > 0)
            {
                sortedArr[i, k] = j + corrDelta;
                k++;
                countArr[i][j]--;
            }
        }
    }

    return sortedArr;
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

PrintResult($"Отсортированный по строкам массив:");
Print2DArray(SortArrayRowsCount(array2D, numMin, numMax));