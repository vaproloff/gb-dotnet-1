//=======================================================
// # 21 Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
//=======================================================

// Метод, выводит результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Стандартное решение. Запрашиваем каждую координату точки, считаем расстояние
// // Метод считывания данных пользователя
// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.Write(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }

// // Метод подсчета расстояния между точками
// double CalculateDistance(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
//     return distance;
// }

// int x1 = ReadData("Введите координату X первой точки: ");
// int y1 = ReadData("Введите координату Y первой точки: ");
// int z1 = ReadData("Введите координату Z первой точки: ");
// int x2 = ReadData("Введите координату X второй точки: ");
// int y2 = ReadData("Введите координату Y второй точки: ");
// int z2 = ReadData("Введите координату Z второй точки: ");

// double result = CalculateDistance(x1, y1, z1, x2, y2, z2);
// PrintResult("Расстояние между точками: " + Math.Round(result, 2));

//=======================================================

// Решение "со звёздочкой". Запрашиваем у пользователя строку, парсим
// Метод считывания данных пользователя
string ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Возвращаем строку
    return Console.ReadLine() ?? "";
}

// Метод, принимает строку в заданном формате, парсит, выдаёт массив массивов координат двух точек
int[][] parseCoords(string coordsLine)
{
    // Разделяем строку на массив из двух строк
    string[] splittedCoordsLine = coordsLine.Split(";");
    // Инициализируем итоговый массив массивов
    int[][] coordArray = new int[splittedCoordsLine.Length][];

    // В циклах заполняем итоговый массив массивов
    for (int i = 0; i < splittedCoordsLine.Length; i++)
    {
        // Строку избавляем от скобок по бокам, сплитим строку на массив по запятой
        string[] coordStringArray = splittedCoordsLine[i].Substring(1, splittedCoordsLine[i].Length - 2).Split(",");
        // Инициализируем массив координат i-й точки
        coordArray[i] = new int[coordStringArray.Length];

        for (int j = 0; j < coordStringArray.Length; j++)
        {
            // Сохраняем распарсенное значение координаты в итоговый массив
            coordArray[i][j] = int.Parse(coordStringArray[j]);
        }
    }

    return coordArray;
}

// Метод, принимает массивы координат двух точек, возвращает подсчитанное расстояние между точками
double CalculateDistance(int[] coords1, int[] coords2)
{
    double sumSquare = 0;

    // В цикле считаем сумму квадратов разностей координат
    for (int i = 0; i < coords1.Length; i++)
    {
        sumSquare += Math.Pow((coords2[i] - coords1[i]), 2);
    }

    double distance = Math.Sqrt(sumSquare);
    return distance;
}

string inputCoordsLine = ReadData("Введите координаты двух точек в формате (x1,y1,z1);(x2,y2,z2) - ");
int[][] coordsArray = parseCoords(inputCoordsLine);
double result = CalculateDistance(coordsArray[0], coordsArray[1]);
PrintResult("Расстояние между точками: " + Math.Round(result, 2));