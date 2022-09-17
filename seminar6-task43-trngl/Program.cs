//=======================================================
// # 43 Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// * Найдите площадь треугольника образованного пересечением 3 прямых
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
    coords[0] = (b2 - b1) / (k1 - k2);
    coords[1] = k1 * coords[0] + b1;

    return coords;
}

// Метод, принимает координаты двух точек, возвращает расстояние между ними
double CalculateDistance(double[] firstDot, double[] secondDot)
{
    return Math.Sqrt(Math.Pow((secondDot[0] - firstDot[0]), 2) + Math.Pow((secondDot[1] - firstDot[1]), 2));
}

// Метод, принимает длины сторон треугольника, возвращает площадь по формуле Герона
double CalcSquareGeron(double a, double b, double c)
{
    double p = (a + b + c) / 2;
    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
}

double inputB1, inputK1, inputB2, inputK2, inputB3, inputK3;
string inputLineB1 = ReadData("Введите параметр B1: ");
string inputLineK1 = ReadData("Введите параметр K1: ");
string inputLineB2 = ReadData("Введите параметр B2: ");
string inputLineK2 = ReadData("Введите параметр K2: ");
string inputLineB3 = ReadData("Введите параметр B3: ");
string inputLineK3 = ReadData("Введите параметр K3: ");

// Если введенные строки преобразуются в число - сохраняем в переменные.
if (double.TryParse(inputLineB1, out inputB1) &&
    double.TryParse(inputLineK1, out inputK1) &&
    double.TryParse(inputLineB2, out inputB2) &&
    double.TryParse(inputLineK2, out inputK2) &&
    double.TryParse(inputLineB3, out inputB3) &&
    double.TryParse(inputLineK3, out inputK3))
{
    if (inputK1 == inputK2 || inputK2 == inputK3 || inputK1 == inputK3)
    {
        Console.WriteLine("Не все прямые пересекаются");
    }
    else
    {
        double[] intersection1to2 = FindIntersection(inputB1, inputK1, inputB2, inputK2);
        double[] intersection1to3 = FindIntersection(inputB1, inputK1, inputB3, inputK3);
        double[] intersection2to3 = FindIntersection(inputB2, inputK2, inputB3, inputK3);

        double sideA = CalculateDistance(intersection1to2, intersection2to3);
        double sideB = CalculateDistance(intersection2to3, intersection1to3);
        double sideC = CalculateDistance(intersection1to2, intersection1to3);

        double triangleSquare = Math.Round(CalcSquareGeron(sideA, sideB, sideC), 2);

        PrintResult($"Площадь треугольника: {triangleSquare}");
    }
}
else
{
    Console.WriteLine("Параметры уравнений введены неверно");
}