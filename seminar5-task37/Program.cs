//=======================================================
// # 37 Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и
// предпоследний и т.д. Результат запишите в новом массиве.
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

// Метод, принимает массив, возвращает массив перемноженных симметричных пар исходного массива
int[] PairMultipliedArray(int[] arr)
{
    // Вводим новый массив, длиной в половину исходного
    int[] pairsMultiplied = new int[arr.Length / 2];

    // В цикле перемножаем пары, заполняем новый массив
    for (int i = 0; i < pairsMultiplied.Length; i++)
    {
        pairsMultiplied[i] = arr[i] * arr[arr.Length - i - 1];
    }

    return pairsMultiplied;
}

int arrLength = 25;
int numMin = 1;
int numMax = 99;
int[] inputArray = FillArray(arrLength, numMin, numMax);
Print1DArray(inputArray);
Print1DArray(PairMultipliedArray(inputArray));