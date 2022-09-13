//=======================================================
// # 34 Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.
// * Отсортировать массив методом пузырька
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
int CountEvenElements(int[] arr)
{
    int evenCount = 0;

    // Проходим по массиву, если элемент - чётный - увеличиваем счётчик
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) evenCount++;
    }

    return evenCount;
}

// Метод, принимает массив, возвращает отсортированный пузырьком изначальный массив
int[] SortArrayBubble(int[] arr)
{
    // Вводим переменную--флаг, которая показывает, нужно ли проходить по массиву для сортировки ещё раз
    bool ifSortNeed = true;

    // Пока флаг равен true - ещё раз проходим по массиву
    while (ifSortNeed == true)
    {
        // начало цикла - перестановок ещё не было, поэтому присваиваем флагу false
        ifSortNeed = false;

        // В цикле сравниваем два соседних элемента попарно, меняя местами при необходимости
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1] > arr[i])
            {
                int tempNumber = arr[i];
                arr[i] = arr[i - 1];
                arr[i - 1] = tempNumber;

                // Мы переставили элементы - присваиваем нашему флагу true
                ifSortNeed = true;
            }
        }
    }

    return arr;
}

// Данные для генерации массива
int arrLength = 20;
int numMin = 100;
int numMax = 999;

// Генерируем массив, выводим в консоль
int[] array = FillArray(arrLength, numMin, numMax);
Console.Write("Получившийся  массив: ");
Print1DArray(array);

// Выводим результат в консоль
PrintResult("Чётных чисел в массиве: " + CountEvenElements(array));

// Выводим отсортированный массив в консоль
Console.Write("Отсортированный массив: ");
Print1DArray(SortArrayBubble(array));