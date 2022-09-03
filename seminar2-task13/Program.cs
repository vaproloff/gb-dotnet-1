//=======================================================
// # 13 Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
//=======================================================

// Метод, запрашивающий у пользователя данные
int AskForData()
{
    Console.Write("Введите число: ");
    string? inputLine = Console.ReadLine();

    int inputNumber = 0;

    // Проверка на текст или null, если число - преобразует
    if (int.TryParse(inputLine, out inputNumber))
    {
        return inputNumber;
    }
    else
    {
        return 0;
    }
}

// Метод, принимает число, преобразует в массив символов, выводит третий символ
char extractThirdDigit(int inputLine)
{
    char[] charArray = inputLine.ToString().ToCharArray();
    return charArray[2];
}

// Метод, вызывает запрос данных пользователя, проверяет, выводит результат
void FindThirdDigitOfNumber()
{
    int userNumber = AskForData();

    if (userNumber > 99)
    {
        Console.WriteLine("Третья цифра: " + extractThirdDigit(userNumber));
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

FindThirdDigitOfNumber();