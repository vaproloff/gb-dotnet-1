//=======================================================
// # 36 Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// * Найдите все пары в массиве и выведите пользователю
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

// Метод, принимает массив, возвращает количество чётных чисел в массиве
int CountSumOddPositionElements(int[] arr)
{
    int sumOddPositionElements = 0;

    // Проходим по нечётным элементам массива, суммируем их
    for (int i = 1; i < arr.Length; i += 2)
    {
        sumOddPositionElements += arr[i];
    }

    return sumOddPositionElements;
}

// Метод, принимает массив, выводит в консоль повторы элементов (спасибо методу подсчёта в задаче 38)
void PrintArrayRepeats(int[] arr)
{
    // Получаем массив с минимальным и максимальным значением изначального массива
    int[] minMaxElements = FindMinMaxElements(arr);
    // Вводим массив, в котором будем подсчитывать количество элементов изначального массива
    int[] countingArray = new int[minMaxElements[1] - minMaxElements[0] + 1];

    // Заполняем массив с количеством элементов
    for (int i = 0; i < arr.Length; i++)
    {
        countingArray[arr[i] - minMaxElements[0]]++;
    }

    // В цикле проходим по массиву с количеством элементов
    for (int i = 0; i < countingArray.Length; i++)
    {
        // Если элемент встречается 2 и больше раз - выводим пару в консоль
        if (countingArray[i] > 1)
        {
            PrintResult("Число " + (i + minMaxElements[0]) + " - " + countingArray[i] + " шт.");
        }
    }
}

// Метод, принимает массив, возвращает массив из минимального и максимального элемента исходного массива
int[] FindMinMaxElements(int[] array)
{
    // Вводим новый массив из двух элементов, кладём в оба - первый элемент исходного массива
    int[] minMaxElements = new int[] { array[0], array[0] };

    // В цикле сравниваем элементы, обновляем минимальные и максимальные элементы
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minMaxElements[0]) minMaxElements[0] = array[i];
        if (array[i] > minMaxElements[1]) minMaxElements[1] = array[i];
    }

    return minMaxElements;
}

// Данные для генерации массива
int arrLength = 20;
int numMin = 0;
int numMax = 50;

// Генерируем массив, выводим в консоль
int[] array = FillArray(arrLength, numMin, numMax);
Console.Write("Получившийся  массив: ");
Print1DArray(array);

// Выводим результат в консоль
PrintResult("Сумма элементов на нечётных позициях: " + CountSumOddPositionElements(array));

// Выводим имеющиеся пары в консоль
PrintArrayRepeats(array);