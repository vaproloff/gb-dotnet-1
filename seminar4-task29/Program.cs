//=======================================================
// # 29 Напишите программу, которая задаёт массив из
// 8 элементов и выводит их на экран.
// * Ввести с клавиатуры длину массива и диапазон значений элементов
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

// Метод, принимает массив, печатает его в консоль
void PrintArray(int[] arr)
{
    string arrString = "[";

    // Добавляем к строке для вывода новый элемент
    for (int i = 0; i < arr.Length - 1; i++)
    {
        arrString += arr[i] + ", ";
    }

    // Добавляем к строке для вывода последний элемент
    arrString += arr[arr.Length - 1] + "]";
    Console.WriteLine(arrString);
}

// Метод, генерирует массив из 0 и 1 заданной длины
int[] GenArray(int arrLength, int numMin, int numMax)
{
    // Инициализируем новый массив заданной длины
    int[] array = new int[arrLength];

    // В цикле заполняем массив случайными элеметнами из заданного диапазона
    for (int i = 0; i < arrLength; i++)
    {
        array[i] = new Random().Next(numMin, numMax + 1);
    }

    return array;
}

int arrLength, numMin, numMax;
string inputLineLength = ReadData("Введите длину массива: ");
string inputLineNumMin = ReadData("Введите минимальное значение: ");
string inputLineNumMax = ReadData("Введите максимальное значение: ");

if (int.TryParse(inputLineLength, out arrLength) &&
    int.TryParse(inputLineNumMin, out numMin) &&
    int.TryParse(inputLineNumMax, out numMax))
{
    PrintArray(GenArray(arrLength, numMin, numMax));
}
else
{
    Console.WriteLine("Это не числа");
}