//=======================================================
// # 13 Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
//=======================================================

// Метод, запрашивающий у пользователя данные
double AskForData()
{
    Console.Write("Введите число: ");
    string? inputLine = Console.ReadLine();

    double inputNumber = 0;

    // Проверка на текст или null, если число - преобразует
    if (double.TryParse(inputLine, out inputNumber))
    {
        return inputNumber;
    }
    else
    {
        return 0;
    }
}

// Метод, принимает число, преобразует в массив символов, выводит третий символ
// char extractThirdDigit(int inputLine, int digitNumber)
// {
//     char[] charArray = inputLine.ToString().ToCharArray();
//     return charArray[digitNumber - 1];
// }

// Метод, принимает число, преобразует в массив символов, выводит i-й символ
int extractThirdDigit(double inputNumber, int digitNumber)
{
    int quantityOfDigits = (int)Math.Log10(inputNumber) + 1;
    return (int)(inputNumber / Math.Pow(10, quantityOfDigits - digitNumber)) % 10;
}

// Метод, вызывает запрос данных пользователя, проверяет, выводит результат
void FindSpecificDigitOfNumber(int digitNumber)
{
    double userNumber = AskForData();

    if (userNumber >= Math.Pow(10, digitNumber - 1))
    {
        Console.WriteLine(digitNumber + "-я цифра: " + extractThirdDigit(userNumber, digitNumber));
    }
    else
    {
        Console.WriteLine(digitNumber + "-й цифры нет");
    }
}

int digitNumber = 3;

FindSpecificDigitOfNumber(digitNumber);