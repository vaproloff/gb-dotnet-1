//=======================================================
// # 27 Напишите программу, которая принимает на вход
// число и выдаёт сумму цифр в числе.
// * Сделать оценку времени алгоритма через вещественные числа и строки
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

// Метод, принимает число в виде строки, возвращает сумму его цифр
int CalculateSumOfDigitsStr(string numString)
{
    int sumOfDigits = 0;

    // В цикле парсим каждый символ по очереди, прибавляем к общей сумме
    for (int i = 0; i < numString.Length; i++)
    {
        sumOfDigits += int.Parse(numString[i].ToString());
    }

    return sumOfDigits;
}

// Метод, принимает число, возвращает сумму его цифр
int CalculateSumOfDigitsMath(int num)
{
    int sumOfDigits = 0;

    // На каждом шаге прибавляем к общей сумме остаток от деления числа на 10 и делим число на 10
    while (num > 0)
    {
        sumOfDigits += num % 10;
        num = num / 10;
    }

    return sumOfDigits;
}

int inputNumber = 0;
string inputLine = ReadData("Введите число: ");

if (int.TryParse(inputLine, out inputNumber))
{
    // Первый по очереди способ всегда оказывался медленнее (я пробовал менять местами),
    // поэтому для чистоты эксперимента я инициализировал переменные отдельно,
    // а выполнение методов я обернул в цикл с многократным повторением.
    DateTime timeStart, timeFinish;
    int sumOfDigits = 0;

    timeStart = DateTime.Now;
    for (int i = 0; i < 1000000; i++)
    {
        sumOfDigits = CalculateSumOfDigitsMath(inputNumber);
    }
    timeFinish = DateTime.Now;
    PrintResult("Способ 1. Сумма цифр в числе: " + sumOfDigits);
    Console.WriteLine("Затраченное время: " + (timeFinish - timeStart));

    Console.WriteLine();

    timeStart = DateTime.Now;
    for (int i = 0; i < 1000000; i++)
    {
        sumOfDigits = CalculateSumOfDigitsStr(inputLine);
    }
    timeFinish = DateTime.Now;
    PrintResult("Способ 2. Сумма цифр в числе: " + sumOfDigits);
    Console.WriteLine("Затраченное время: " + (timeFinish - timeStart));
}
else
{
    PrintResult("Это не число");
}