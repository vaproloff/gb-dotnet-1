//=======================================================
// # 55 Задайте двумерный массив. Напишите программу, которая
// заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.
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

// Метод, принимает двумерный массив, возвращает транспонированный массив
// int[,] TranspondMatrix(int[,] arr)
// {
//     int[,] swappedArr = new int[arr.GetLength(1), arr.GetLength(0)];

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             swappedArr[j, i] = arr[i, j];
//         }
//     }

//     return swappedArr;
// }

// Метод, принимает квадратный двумерный массив, меняет строки и столбцы местами
void SwapRowsCols(int[,] arr)
{
    int buf = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            buf = arr[j, i];
            arr[i, j] = arr[j, i];
            arr[j, i] = buf;
        }
    }
}

bool IfTranspondable(int[,] arr)
{
    return arr.GetLength(0) == arr.GetLength(1);
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

// PrintResult($"Изменённый массив:");
// Print2DArray(TranspondMatrix(array2D));

if (IfTranspondable(array2D))
{
    SwapRowsCols(array2D);
    PrintResult("Изменённый массив:");
    Print2DArray(array2D);
}
else
{
    PrintResult("Данный массив - не квадратный");
}