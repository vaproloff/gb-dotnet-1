//=======================================================
// # 33 Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
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

// Метод поиска заданного элемента в массиве
bool ContainsElement(int[] arr, int numberSearch)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == numberSearch) return true;
    }

    return false;
}

int arrayLength = int.Parse(ReadData("Введите длину массива: "));
int downBorder = int.Parse(ReadData("Введите нижнюю границу заполнения массива: "));
int topBorder = int.Parse(ReadData("Введите верннюю границу заполнения массива: "));
int[] inputArray = FillArray(arrayLength, downBorder, topBorder);
Print1DArray(inputArray);

int numberSearch = int.Parse(ReadData("Введите искомое число: "));
PrintResult(ContainsElement(inputArray, numberSearch) ? "Число есть в массиве" : "Числа нет в массиве");

// С помощью встроенного метода:
PrintResult(Array.IndexOf(inputArray, numberSearch) >= 0 ? "Число есть в массиве" : "Числа нет в массиве");