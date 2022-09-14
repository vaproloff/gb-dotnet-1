//=======================================================
// # 38 Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
//=======================================================

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Метод, печатает одномерный массив
void Print1DArray(double[] arr)
{
    string arrString = "[";

    for (int i = 0; i < arr.Length - 1; i++)
    {
        arrString += arr[i] + "; ";
    }

    arrString += arr[arr.Length - 1] + "]";
    Console.WriteLine(arrString);
}

// Метод генерации и заполнения массива вещественными числами
double[] FillArrayDouble(int arrLength, int numMin, int numMax)
{
    // Создаём массив
    double[] array = new double[arrLength];

    // Тест границ
    if (numMin < numMax)
    {
        // Заполняем массив
        for (int i = 0; i < arrLength; i++)
        {
            array[i] = new Random().NextDouble() * (numMax - numMin) + numMin;
        }
    }

    return array;
}

// Метод, принимает массив, возвращает массив из минимального и максимального элемента исходного массива
double[] FindMinMaxElements(double[] array)
{
    // Вводим новый массив из двух элементов, кладём в оба - первый элемент исходного массива
    double[] minMaxElements = new double[] { array[0], array[0] };

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
double[] array = FillArrayDouble(arrLength, numMin, numMax);
Console.Write("Получившийся  массив: ");
Print1DArray(array);

Console.WriteLine();

double[] minMaxElements = FindMinMaxElements(array);
// Выводим результат в консоль
PrintResult("Минимальный элемент массива: " + minMaxElements[0]);
PrintResult("Максимальный элемент массива: " + minMaxElements[1]);
PrintResult("Разница между ними: " + (minMaxElements[1] - minMaxElements[0]));