//=======================================================
// # 18 Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).
//=======================================================

// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод, принимает номер четверти, показывает диапазон координат
string QuarterBorderAsk(int numQuarter)
{
    if (numQuarter == 1) return "x > 0, y > 0";
    if (numQuarter == 2) return "x > 0, y < 0";
    if (numQuarter == 3) return "x < 0, y < 0";
    if (numQuarter == 4) return "x < 0, y > 0";

    return "";
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int numQuarter = ReadData("Введите номер четверти: ");
string result = QuarterBorderAsk(numQuarter);
PrintResult(result);