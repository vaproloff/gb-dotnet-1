//=======================================================
// # 38* Отсортируйте массив методом вставки и методом подсчета,
// а затем найдите разницу между первым и последним элементом.
// Для задачи со звездочкой использовать заполнение массива целыми числами.
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

// Метод, принимает массив, возвращает отсортированный вставкой массив
int[] SortArrayInsertion(int[] arr)
{
    // В цикле берём по очереди элементы, начиная со второго
    for (int i = 1; i < arr.Length; i++)
    {
        // Цикл, ищущий, куда вставить текущий элемент, передвигая его в сторону начала массива
        for (int j = i - 1; j >= 0; j--)
        {
            // Сравниваем попарно, меняя местами при необходимости
            if (arr[j + 1] < arr[j])
            {
                int temp = arr[j + 1];
                arr[j + 1] = arr[j];
                arr[j] = temp;
            }
            // Если предыдущий элемент меньше следующего - место найдено, прерываем внутренний цикл
            else break;
        }
    }

    return arr;
}

// Метод, принимает массив, возвращает отсортированный подсчётом новый массив
int[] SortArrayCounting(int[] arr)
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

    // Вводим новый массив и счётчик для него
    int[] sortedArray = new int[arr.Length];
    int currentIndex = 0;
    // В цикле проходим по массиву с количеством элементов
    for (int i = 0; i < countingArray.Length; i++)
    {
        // Если и пока текущий элемент (количество) больше нуля - заполняем по очереди новый отсортированный массив
        while (countingArray[i] > 0)
        {
            // Корректировка на величину минимального элемента
            sortedArray[currentIndex] = i + minMaxElements[0];
            // Увеличиваем счётчик нового массива
            currentIndex++;
            // Уменьшаем элемент количества
            countingArray[i]--;
        }
    }

    return sortedArray;
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
int numMin = 1;
int numMax = 99;

// Генерируем массив, выводим в консоль
int[] array = FillArray(arrLength, numMin, numMax);
int[] sortedArrBubble = SortArrayBubble((int[])array.Clone());
int[] sortedArrInsertion = SortArrayInsertion((int[])array.Clone());
int[] sortedArrCounting = SortArrayCounting(array);

Console.Write("Изначальный  массив: ");
Print1DArray(array);
Console.Write("Отсортированный  массив пузырьком: ");
Print1DArray(sortedArrInsertion);
Console.Write("Отсортированный  массив вставкой: ");
Print1DArray(sortedArrInsertion);
Console.Write("Отсортированный  массив подсчётом: ");
Print1DArray(sortedArrCounting);
Console.WriteLine();

// Выводим результат в консоль
PrintResult("Минимальный элемент массива: " + sortedArrCounting[0]);
PrintResult("Максимальный элемент массива: " + sortedArrCounting[sortedArrCounting.Length - 1]);
PrintResult("Разница между ними: " + (sortedArrCounting[sortedArrCounting.Length - 1] - sortedArrCounting[0]));
Console.WriteLine();

// Замеры времени.
// Поскольку первый по очереди способ всегда медленнее,
// для чистоты эксперимента инициализируем переменные времени,
// выполнение методов оборачиваем в цикл с многократным повторением.
DateTime timeStart, timeFinish;
timeStart = DateTime.Now;
for (int i = 0; i < 1000000; i++)
{
    sortedArrBubble = SortArrayBubble((int[])array.Clone());
}
timeFinish = DateTime.Now;
PrintResult("Сортировка пузырьком. Затраченное время: " + (timeFinish - timeStart));

timeStart = DateTime.Now;
for (int i = 0; i < 1000000; i++)
{
    sortedArrInsertion = SortArrayInsertion((int[])array.Clone());
}
timeFinish = DateTime.Now;
PrintResult("Сортировка вставкой. Затраченное время: " + (timeFinish - timeStart));

timeStart = DateTime.Now;
for (int i = 0; i < 1000000; i++)
{
    // Для чистоты эксперимента со временем - добавил .Clone(), хотя метод и так выдаёт новый массив
    sortedArrCounting = SortArrayCounting((int[])array.Clone());
}
timeFinish = DateTime.Now;
PrintResult("Сортировка подсчётом. Затраченное время: " + (timeFinish - timeStart));