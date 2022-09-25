//=======================================================
// # 58 Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
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

// Метод, принимает две матрицы, возвращает матрицу произведений двух матриц
int[,] MatrixProduct(int[,] matrixA, int[,] matrixB)
{
    // Вводим матрицу произведений с числом строк матрицы А и столбцов матрицы В
    int[,] matrixAxB = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixAxB.GetLength(0); i++)
    {
        for (int j = 0; j < matrixAxB.GetLength(1); j++)
        {
            // В цикле находим сумму произведений i-й строки матрицы А и j-го столбца матрицы B
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixAxB[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return matrixAxB;
}

// Метод, принимает кол-во строк матрицы А и столбцов матрицы B, возвращает можно ли найти произведение матриц
bool TestMatrixProduction(int colsA, int rowsB)
{
    return colsA == rowsB;
}

// Данные для генерации массива
int numMin = 10;
int numMax = 99;

int inputRowsA = ReadData("Введите количество строк матрицы A: ");
int inputColsA = ReadData("Введите количество столбцов матрицы A: ");
int inputRowsB = ReadData("Введите количество строк матрицы B: ");
int inputColsB = ReadData("Введите количество столбцов матрицы B: ");

if (TestMatrixProduction(inputColsA, inputRowsB))
{
    int[,] matrixA = Fill2DArray(inputRowsA, inputColsA, numMin, numMax);
    int[,] matrixB = Fill2DArray(inputRowsB, inputColsB, numMin, numMax);

    PrintResult($"Матрица А:");
    Print2DArray(matrixA);
    Console.WriteLine();
    PrintResult($"Матрица B:");
    Print2DArray(matrixB);
    Console.WriteLine();
    PrintResult($"Матрица AxB:");
    Print2DArray(MatrixProduct(matrixA, matrixB));
}
else
{
    PrintResult("Невозможно умножить матрицу A на матрицу B");
}