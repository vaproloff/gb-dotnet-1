//=======================================================
// # 57 Составить частотный словарь элементов двумерного
// массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.
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

//  Метод, выводит частотный массив
void PrintFreqArray(int[] arr, int minElement)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            Console.WriteLine($"{i + minElement} - {arr[i]} шт.");
        }
    }
}

// Метод, принимает двумерный массив, возвращает одномерный массив средних арифметических по столбцам
int[] CountElementFrequency(int[,] arr, int minElement, int maxElement)
{
    int[] frequencyArr = new int[maxElement - minElement + 1];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            frequencyArr[arr[i, j] - minElement]++;
        }
    }

    return frequencyArr;
}

// Данные для генерации массива
int numMin = 10;
int numMax = 12;

int inputRows = ReadData("Введите количество строк: ");
int inputCols = ReadData("Введите количество столбцов: ");
int[,] array2D = Fill2DArray(inputRows, inputCols, numMin, numMax);
PrintResult($"Случайный массив целых чисел {inputRows}x{inputCols}:");
Print2DArray(array2D);
Console.WriteLine();
PrintFreqArray(CountElementFrequency(array2D, numMin, numMax), numMin);


// // Возвращает частотный словарь элементов двумерного массива
// SortedDictionary<int, int> CountDictionary(int[,] array)
// {
//     SortedDictionary<int, int> dict = new SortedDictionary<int, int>();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {

//         for (int j = i + 1; j < array.GetLength(1); j++)
//         {
//             if (dict.ContainsKey(array[j, i])) dict[array[j, i]] = dict[array[j, i]] + 1;
//             else dict.Add(array[j, i], 1);
//         }
//     }

//     return dict;
// }

// SortedDictionary<int, int> dict = CountDictionary(array2D);

// PrintResult("Сколько повторений\n" + "\nЧисло");
// foreach (KeyValuePair<int, int> kvp in dict)
// {
//     PrintResult($"{kvp.Value.ToString()}, {kvp.Key.ToString()}");
// }