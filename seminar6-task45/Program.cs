//=======================================================
// # 45 Напишите программу, которая будет создавать копию
// заданного одномерного массива с помощью поэлементного копирования.
//=======================================================

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
int[] FillArray(int arrLength, int numMin, int numMax)
{
    // Создаём массив
    int[] array = new int[arrLength];

    // Тест границ
    if (numMin < numMax)
    {
        // Заполняем массив
        for (int i = 0; i < arrLength; i++)
        {
            array[i] = new Random().Next(numMin, numMax + 1);
        }
    }

    return array;
}

// Метод копирования исходного массива
int[] CopyArray(int[] arr)
{
    int[] copiedArray = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        copiedArray[i] = arr[i];
    }

    return copiedArray;
}

// Данные для генерации массива
int arrLength = 20;
int numMin = 1;
int numMax = 99;

// Генерируем массив, выводим в консоль
int[] array = FillArray(arrLength, numMin, numMax);
Console.Write("Изначальный  массив: ");
Print1DArray(array);

int[] copiedArray = CopyArray(array);
Console.Write("Копированный  массив: ");
Print1DArray(copiedArray);

Console.WriteLine(array == copiedArray ? "Это один и тот же массив" : "Это не один и тот же массив");

Console.Write("Копированный  массив через Clone: ");
Print1DArray((int[])array.Clone());