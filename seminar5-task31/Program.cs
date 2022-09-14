//=======================================================
// # 31 Задайте массив из 12 элементов, заполненный случайными
// числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
//=======================================================

// Метод считывания данных пользователя
string ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем строку
    string inputLine = Console.ReadLine() ?? "";
    // Возвращаем значение
    return inputLine;
}

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

// Метод, принимает массив, возвращает массив сумм отрицательных и положительных элементов исходного массива
int[] NegativePositiveSums(int[] arr)
{
    // Вводим массив из двух элементов
    int[] sums = new int[2];

    // В цикле проходим по исходному массиву, считая суммы положительных и отрицательных элементов
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sums[0] += arr[i];
        }
        else
        {
            sums[1] += arr[i];
        }
    }

    return sums;
}

int arrayLength = int.Parse(ReadData("Введите длину массива: "));
int downBorder = int.Parse(ReadData("Введите нижнюю границу заполнения массива: "));
int topBorder = int.Parse(ReadData("Введите верннюю границу заполнения массива: "));

int[] inputArray = FillArray(arrayLength, downBorder, topBorder);
Print1DArray(inputArray);
int[] sumArray = NegativePositiveSums(inputArray);
PrintResult("Сумма > 0: " + sumArray[0] + ". Сумма < 0: " + sumArray[1]);