//=======================================================
// # 52 Задайте двумерный массив из целых чисел. Найдите
// среднее арифметическое элементов в каждом столбце.
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
void Print1DArrayDouble(double[] arr)
{
    string arrString = String.Empty;

    for (int i = 0; i < arr.Length - 1; i++)
    {
        arrString += arr[i] + "; ";
    }

    arrString += arr[arr.Length - 1];
    Console.WriteLine(arrString);
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

// Метод, принимает двумерный массив, возвращает одномерный массив средних арифметических по столбцам
double[] CalcAvrgColumns(int[,] arr)
{
    // Создаём новый одномерный массив
    double[] colAverages = new double[arr.GetLength(1)];

    // В циклах заполняем массив, прибавляя значения по столбцам
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            colAverages[j] += arr[i, j];
        }
    }

    return DivideArr(colAverages, arr.GetLength(0));
}

// Метод, делящий каждый элемент массива на заданный делитель
double[] DivideArr(double[] arr, int divider)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(arr[i] / divider, 2);
    }

    return arr;
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
PrintResult($"Cредние арифметические по столбцам:");
Print1DArrayDouble(CalcAvrgColumns(array2D));