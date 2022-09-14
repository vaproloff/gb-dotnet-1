//=======================================================
// # 32 Напишите программу замена элементов массива:
// положительные элементы замените на
// соответствующие отрицательные, и наоборот.
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

// Метод замены элементов в массиве на с противоположным знаком
int[] InverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -(arr[i]);
    }

    return arr;
}

int arrayLength = int.Parse(ReadData("Введите длину массива: "));
int downBorder = int.Parse(ReadData("Введите нижнюю границу заполнения массива: "));
int topBorder = int.Parse(ReadData("Введите верннюю границу заполнения массива: "));

int[] inputArray = FillArray(arrayLength, downBorder, topBorder);
Print1DArray(inputArray);
Print1DArray(InverseArray(inputArray));
Print1DArray(inputArray);