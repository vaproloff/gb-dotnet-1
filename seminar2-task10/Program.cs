//=======================================================
// # 10 Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.
//=======================================================

// Метод, запрашивающий у пользователя данные
int AskForData()
{
    Console.Write("Введите трёхзначное число: ");
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

// Вариант 1 - функция, принимает число, выдаёт вторую цифру (с помощью массива символов)
// char CalculateSecondDigit(int inputNumber)
// {
//     char[] charArray = inputNumber.ToString().ToCharArray();
//     return charArray[1];
// }

// Вариант 2 - функция, принимает число, выдаёт вторую цифру (с помощью математических вычислений)
int CalculateSecondDigit(int inputNumber)
{
    return (inputNumber / 10) % 10;
}

// Метод, проверка числа на трёхзначное, вывод результата в консоль 
void FindSecondDigitOfNumber()
{
    int number = AskForData();
    if (number > 99 && number < 1000)
    {
        Console.WriteLine("Вторая цифра: " + CalculateSecondDigit(number));
    }
    else
    {
        Console.WriteLine("Это не трёхзначное число");
    }
}

FindSecondDigitOfNumber();