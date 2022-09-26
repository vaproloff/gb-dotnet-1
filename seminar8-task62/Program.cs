//=======================================================
// # 62 Напишите программу, которая заполнит спирально массив.
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

// Метод генерации и заполнения двумерного массива спирально
int[,] Fill2DArraySpiral(int rows, int cols)
{
    int[,] array2D = new int[rows, cols];

    int row = 0; int col = 0; // Счётчики по массиву
    int dX = 1; int dY = 0; // Изменения счётчиков row и col на каждом шаге
    int steps = cols; // Количество шагов до поворота
    int dirChangeCount = 0; // Количество осуществлённых поворотов

    for (int i = 0; i < rows * cols; i++)
    {
        // Заполняем текущий элемент массива, уменьшаем счётчик шагов
        array2D[row, col] = i + 1;
        steps--;

        // Если шагов в текущем направлении не осталось - меняем направление
        if (steps == 0)
        {
            int buf = dX;
            dX = -dY;
            dY = buf;
            steps = Math.Abs(dY) * rows + Math.Abs(dX) * cols - (dirChangeCount / 2 + 1); // Вычисляем количество предстоящих шагов
            dirChangeCount++;
        }

        row += dY;
        col += dX;
    }

    return array2D;
}

int inputRows = ReadData("Введите количество строк: ");
int inputCols = ReadData("Введите количество столбцов: ");
int[,] arrSpiral = Fill2DArraySpiral(inputRows, inputCols);
PrintResult($"Спиральный массив {inputRows}x{inputCols}:");
Print2DArray(arrSpiral);