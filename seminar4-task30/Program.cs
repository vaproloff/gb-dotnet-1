//=======================================================
// # 30 Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в случайном порядке.
//=======================================================

// Метод, принимает массив, печатает его в консоль
void PrintArray(int[] arr)
{
    string arrString = "[";

    for (int i = 0; i < arr.Length - 1; i++)
    {
        arrString += arr[i] + ", ";
    }

    arrString += arr[arr.Length - 1] + "]";
    Console.WriteLine(arrString);
}

// Метод, генерирует массив из 0 и 1 заданной длины
int[] GenArray(int arrLength)
{
    int[] array = new int[arrLength];

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = new Random().Next(0, 2);
    }

    return array;
}

int[] array = GenArray(8);
PrintArray(array);