//=======================================================
// # 50 Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого
// элемента или же указание, что такого элемента нет.
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

// Метод, принимает массив и позицию, возвращает элемент
int PickArrayElement(int[,] arr, int row, int col)
{
    return arr[row - 1, col - 1];
}

// Метод, принимает массив и позицию, проверяет наличие позиции в массиве
bool CheckArrayElement(int[,] arr, int row, int col)
{
    bool ifArrayHasPosition = row > 0 && row <= arr.GetLength(0) &&
                              col > 0 && col <= arr.GetLength(1);
    return ifArrayHasPosition;
}

// Метод, принимает массив и позицию, печатает элемент в консоль
void PrintArrayElement(int[,] arr, int row, int col)
{
    if (CheckArrayElement(arr, row, col))
    {
        PrintResult($"Элемент на позиции ({row},{col}): {PickArrayElement(arr, row, col)}");
    }
    else
    {
        PrintResult($"Указанная позиция за пределами массива");
    }
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

int rowPosition = ReadData("Введите номер строки: ");
int colPosition = ReadData("Введите номер столбца: ");
PrintArrayElement(array2D, rowPosition, colPosition);