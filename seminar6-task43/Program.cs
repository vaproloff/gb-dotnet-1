//=======================================================
// # 43 Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
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

// Метод, принимает параметры уравнений, возвращает массив с координатами пересечения прямых
double[] FindIntersection(double b1, double k1, double b2, double k2)
{
    // Вводим массив, в которых запишем координаты точки пересечения
    double[] coords = new double[2];

    // Вычисляем координаты:
    // k1x + b1 = k2x + b2 - уравниваем правые части уравнений
    // k1x - k2x = b2 - b1
    // x = (b2 - b1) / (k1 - k2) - выводим x
    coords[0] = (b2 - b1) / (k1 - k2);
    coords[1] = k1 * coords[0] + b1;

    return coords;
}

double inputB1, inputK1, inputB2, inputK2;
string inputLineB1 = ReadData("Введите параметр B1: ");
string inputLineK1 = ReadData("Введите параметр K1: ");
string inputLineB2 = ReadData("Введите параметр B2: ");
string inputLineK2 = ReadData("Введите параметр K2: ");

// Если введенные строки преобразуются в число - сохраняем в переменные.
if (double.TryParse(inputLineB1, out inputB1) &&
    double.TryParse(inputLineK1, out inputK1) &&
    double.TryParse(inputLineB2, out inputB2) &&
    double.TryParse(inputLineK2, out inputK2))
{
    if (inputK1 == inputK2)
    {
        Console.WriteLine("Точки пересечения нет");
    }
    else
    {
        double[] intersectionCoords = FindIntersection(inputB1, inputK1, inputB2, inputK2);
        PrintResult($"Точка пересечения прямых: [{intersectionCoords[0]}, {intersectionCoords[1]}]");
    }
}
else
{
    Console.WriteLine("Параметры уравнений введены неверно");
}