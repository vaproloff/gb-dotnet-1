//=======================================================
// # 60 Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет
// построчно выводить массив, добавляя индексы каждого элемента.
//=======================================================

// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Метод, печатает трёхмерный массив построчно
void Print3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.WriteLine($"{arr[i, j, k]} ({i},{j},{k})");
            }
        }
    }
}

// Метод генерации и заполнения списка уникальных двузначных чисел вразброс
List<int> FillUniqueList(int listLength, int numStart)
{
    // Создаём список, заполняем двузначными числами по порядку
    List<int> listUnique = new List<int>();
    for (int i = 0; i < listLength; i++)
    {
        listUnique.Add(i + numStart);
    }
    // Рандомизируем список и возвращаем
    listUnique.Sort((x, y) => new Random().Next(-1, 1));
    return listUnique;
}

// Метод генерации и заполнения трёхмерного массива
int[,,] Fill3DArrayUnique(int layers, int rows, int cols, int numStart)
{
    int[,,] array3D = new int[layers, rows, cols];
    // Создаём список уникальных двухначных чисел и счётчик
    List<int> listUnique = FillUniqueList(layers * rows * cols, numStart);
    int listIndex = 0;

    // Заполняем массив из списка уникальных двузначных чисел
    for (int i = 0; i < layers; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < cols; k++)
            {
                array3D[i, j, k] = listUnique[listIndex];
                listIndex++;
            }
        }
    }

    return array3D;
}

// Данные для генерации массива
int numStart = 10;

int inputLayers = ReadData("Введите количество слоёв: ");
int inputRows = ReadData("Введите количество строк: ");
int inputCols = ReadData("Введите количество столбцов: ");

// Проверка, если элементов будущего массива будет больше, чем уникальных двузначных чисел
if (inputLayers * inputRows * inputCols <= 90)
{
    int[,,] array3D = Fill3DArrayUnique(inputLayers, inputRows, inputCols, numStart);
    PrintResult($"Массив неповторяющихся двухначных чисел:");
    Print3DArray(array3D);
}
else
{
    PrintResult("Элементов массива будет больше, чем двузначных чисел. Уменьшите вводные данные.");
}