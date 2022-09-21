//=======================================================
// # 50 Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого
// элемента или же указание, что такого элемента нет.
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру
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

// Метод, печатает одномерный массив, выделяет элемент с указанной позицией
void Print2DArrColorElement(long[,] arr, int elementRow = -1, int elementCol = -1)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // Если позиция совпадает с заданной - выделяем элемент красным цветом
            if ((i == elementRow - 1) && (j == elementCol - 1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{arr[i, j]} ");
                Console.ResetColor();
            }
            else Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Метод генерации двумерного массива числами Фибоначчи
long[,] Fill2DArrayFibo(int rows, int cols)
{
    // Создаём массив и два первых элемента
    long[,] array2D = new long[rows, cols];
    long prevNum = 0;
    long nextNum = 1;

    // В циклах заполняем массив
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array2D[i, j] = prevNum;
            prevNum = nextNum;
            nextNum = prevNum + array2D[i, j];
        }
    }

    return array2D;
}

// Метод, принимает массив и позицию, печатает результат
void PrintColorElement(long[,] arr, int row, int col)
{
    // Проверяем вхождение позиции элемента в массив 
    bool ifArrayHasPosition = row > 0 && row <= arr.GetLength(0) &&
                              col > 0 && col <= arr.GetLength(1);

    if (ifArrayHasPosition)
    {
        Print2DArrColorElement(arr, row, col);
    }
    else
    {
        PrintResult($"Указанная позиция за пределами массива");
    }
}

int inputRows = ReadData("Введите количество строк: ");
int inputCols = ReadData("Введите количество столбцов: ");
long[,] array2D = Fill2DArrayFibo(inputRows, inputCols);
PrintResult($"Массив чисел Фибоначчи {inputRows}x{inputCols}:");
Print2DArrColorElement(array2D);
Console.WriteLine();

int rowPosition = ReadData("Введите номер строки: ");
int colPosition = ReadData("Введите номер столбца: ");
PrintColorElement(array2D, rowPosition, colPosition);