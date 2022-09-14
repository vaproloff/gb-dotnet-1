//=======================================================
// # 35 Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых
// лежат в отрезке [10,99].
//=======================================================

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Метод, печатает одномерный массив
void Print1DArray(int[] arr)
{
    string arrString = "[";

    for (int i = 0; i < arr.Length - 1; i++)
    {
        arrString += arr[i] + ", ";
    }

    arrString += arr[arr.Length - 1] + "]";
    Console.WriteLine(arrString);
}

// Метод генерации и заполнения массива
int[] FillArray(int arrLength, int downBorder, int topBorder)
{
    // Генератор случайных чисел
    Random numSintezator = new Random();

    // Создаём массив
    int[] array = new int[arrLength];

    // Тест границ
    if (downBorder < topBorder)
    {
        // Заполняем массив
        for (int i = 0; i < arrLength; i++)
        {
            array[i] = numSintezator.Next(downBorder, topBorder + 1);
        }
    }

    return array;
}

// Метод подсчёта элементов в заданном отрезке
int CountElements(int[] arr, int minNum, int maxNum)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= minNum && arr[i] <= maxNum)
        {
            count++;
        };
    }

    return count;
}

int arrLength = 123;
int[] inputArray = FillArray(arrLength, 0, 1000);
Print1DArray(inputArray);

int numMin = 10;
int numMax = 99;
PrintResult($"В отрезке [{numMin},{numMax}] - " + CountElements(inputArray, numMin, numMax) + " элементов");