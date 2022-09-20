//=======================================================
// # 48 Задайте двумерный массив размера m на n, каждый
// элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
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
    for (int rows = 0; rows < arr.GetLength(0); rows++)
    {
        for (int cols = 0; cols < arr.GetLength(1); cols++)
        {
            Console.Write($"{arr[rows, cols]} ");
        }
        Console.WriteLine();
    }
}

// Метод генерации и заполнения массива
int[,] Fill2DArrMN(int rows, int cols, int numMin, int numMax)
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
                array2D[i, j] = i + j;
            }
        }
    }

    return array2D;
}

// Данные для генерации массива
int numMin = 1;
int numMax = 99;

int rows = ReadData("Введите количество строк: ");
int cols = ReadData("Введите количество столбцов: ");

Console.WriteLine($"Массив {rows}x{cols}:");
Fill2DArrMN(Fill2DArrayMN(rows, cols, numMin, numMax));