//=======================================================
// # 69 Напишите программу, которая на вход принимает два
// числа A и B, и возводит число A в натуральную степень B.
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

// Метод, возводит А в степень В рекурсией
int RecPow(int numA, int numB)
{
    if (numB == 1) return numA;
    return numA * RecPow(numA, numB - 1);
}

// Метод, возводит А в степень В циклом
int NoRecPow(int num, int pow)
{
    int result = 1;
    for (int i = 0; i < pow; i++)
    {
        result = result * num;
    }
    return result;
}

// Метод, возводит А в степень В рекурсией попарно
int MyPow(int number, int pow)
{
    if (pow == 2)
    {
        return number * number;
    }
    if (pow == 1)
    {
        return number;
    }

    if (pow % 2 == 0)
    {
        return MyPow(number, pow / 2) * MyPow(number, pow / 2);
    }
    else
    {
        return MyPow(number, pow / 2) * MyPow(number, pow / 2 + 1);
    }

}

int inputNumA = ReadData("Введите число A: ");
int inputNumB = ReadData("Введите число B: ");
int out1 = 0;
int out2 = 0;
int out3 = 0;
double out4 = 0;

DateTime d1 = DateTime.Now;
for (int i = 0; i < 10000000; i++)
{
    out1 = RecPow(inputNumA, inputNumB);
}
PrintResult("Рекурентное решение " + (DateTime.Now - d1));

DateTime d2 = DateTime.Now;
for (int i = 0; i < 10000000; i++)
{
    out2 = NoRecPow(inputNumA, inputNumB);
}
PrintResult("Обычное решение " + (DateTime.Now - d2));

DateTime d3 = DateTime.Now;
for (int i = 0; i < 10000000; i++)
{
    out3 = MyPow(inputNumA, inputNumB);
}
PrintResult("Суперрекурентное решение " + (DateTime.Now - d3));

DateTime d4 = DateTime.Now;
for (int i = 0; i < 10000000; i++)
{
    out4 = Math.Pow(inputNumA, inputNumB);
}
PrintResult("Math.Pow " + (DateTime.Now - d4));