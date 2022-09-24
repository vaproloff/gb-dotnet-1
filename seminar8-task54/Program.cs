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

// Метод, принимает массив, сортирует его строки по убыванию
void SortArrayRowsList(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        SortArrayRow(arr, i);
    }
}

// Метод, принимает массив и номер строки, сортирует эту строку в массиве с помощью конструкции List
void SortArrayRow(int[,] arr, int rowIndex)
{
    // Создаём список и заполняемна основе i-й строки
    List<int> row = new List<int>();

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        row.Add(arr[rowIndex, j]);
    }
    // Сортируем элементы списка по убыванию
    row.Sort((x, y) => y - x);
    // Заполняем строку изначального массива из отсортированного списка
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[rowIndex, j] = row[j];
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
SortArrayRowsList(array2D);
PrintResult($"Отсортированный по строкам массив:");
Print2DArray(array2D);