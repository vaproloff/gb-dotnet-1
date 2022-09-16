//=======================================================
// # 39 Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а
// первый - на последнем и т.д.)
//=======================================================

// Метод, печатает одномерный массив
void Print1DArray(int[] arr)
{
    string arrString = "[";

    for (int i = 0; i < arr.Length - 1; i++)
    {
        arrString += arr[i] + "; ";
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

// Метод разворота массива с созданием нового
int[] ReverseNewArray(int[] arr)
{
    // Создаём новый массив
    int[] reversedArr = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        reversedArr[arr.Length - i - 1] = arr[i];
    }

    return reversedArr;
}

// Метод разворота исходного массива
int[] ReverseArray(int[] arr)
{
    int bufElement = 0;

    for (int i = 0; i < arr.Length / 2; i++)
    {
        bufElement = arr[arr.Length - i -1];
        arr[arr.Length - i -1] = arr[i];
        arr[i] = bufElement;
    }

    return arr;
}

// Данные для генерации массива
int arrLength = 20;
int numMin = 1;
int numMax = 99;

// Генерируем массив, выводим в консоль
int[] array = FillArray(arrLength, numMin, numMax);
Console.Write("Изначальный  массив: ");
Print1DArray(array);

int[] reversedNewArray = ReverseNewArray(array);
Console.Write("Новый перевернутый  массив: ");
Print1DArray(reversedNewArray);

array = ReverseArray(array);
Console.Write("Исходный перевернутый  массив: ");
Print1DArray(array);