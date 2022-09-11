//=======================================================
// # 25 Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.
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

// Метод, принимает два числа, возводит в степень с помощью цикла, возвращает результат
long CalculatePowCycle(int numA, int numB)
{
    long numPowered = 1;

    for (int i = 1; i <= numB; i++)
    {
        numPowered = numPowered * numA;
    }

    return numPowered;
}

// Метод, принимает два числа, возводит в степень с помощью Math, возвращает результат
double CalculatePowMath(int numA, int numB)
{
    return Math.Pow(numA, numB);
}

int inputNumberA, inputNumberB;
string inputLineA = ReadData("Введите число A: ");
string inputLineB = ReadData("Введите число B: ");

if (int.TryParse(inputLineA, out inputNumberA) && int.TryParse(inputLineB, out inputNumberB))
{
    long numPowered1 = CalculatePowCycle(inputNumberA, inputNumberB);
    PrintResult("Способ 1. " + inputNumberA + " в степени " + inputNumberB + ": " + numPowered1);

    double numPowered2 = CalculatePowMath(inputNumberA, inputNumberB);
    PrintResult("Способ 2. " + inputNumberA + " в степени " + inputNumberB + ": " + numPowered2);
}
else
{
    PrintResult("Это не числа");
}