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
void Print2DArrColorElement(double[,] arr, int elementRow = -1, int elementCol = -1)
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

// Метод генерации и заполнения двумерного массива числами Фибоначчи
double[,] Fill2DArrayFibo(int rows, int cols)
{
    // Получаем массив чисел Фибоначчи нужной длины
    double[] fiboArr = FibonacciArray(rows * cols);
    int fiboIndex = 0;

    // Создаём массив
    double[,] array2D = new double[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array2D[i, j] = fiboArr[fiboIndex];
            fiboIndex++;
        }
    }

    return array2D;
}

// Метод генерации одномерного массива числами Фибоначчи нужной длины
double[] FibonacciArray(int number)
{
    // Создаём новый массив
    double[] fibonacciArr = new double[number];
    // Если длина больше 1, то во второй элемент кладём 1
    if (number > 1) fibonacciArr[1] = 1;

    // В цикле заполняем массив последовательностью Фибоначчи
    for (int i = 2; i < number; i++)
    {
        fibonacciArr[i] = fibonacciArr[i - 2] + fibonacciArr[i - 1];
    }

    return fibonacciArr;
}

// Метод, принимает массив и позицию, печатает результат
void PrintColorElement(double[,] arr, int row, int col)
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
double[,] array2D = Fill2DArrayFibo(inputRows, inputCols);
PrintResult($"Массив чисел Фибоначчи {inputRows}x{inputCols}:");
Print2DArrColorElement(array2D);
Console.WriteLine();

int rowPosition = ReadData("Введите номер строки: ");
int colPosition = ReadData("Введите номер столбца: ");
PrintColorElement(array2D, rowPosition, colPosition);