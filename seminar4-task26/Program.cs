//=======================================================
// # 26 Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.
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

// Вариант с длиной строки
int CalculateDigitsStr(int num)
{
    return num.ToString().Length;
}

// Вариант с логарифмом
int CalculateDigitsLog(int num)
{
    return (int)(Math.Log10(num) + 1);
}

int number = ReadData("Введите число: ");

int numberOfDigits = CalculateDigitsStr(number);
PrintResult("Количество цифр в числе: " + numberOfDigits);

numberOfDigits = CalculateDigitsLog(number);
PrintResult("Количество цифр в числе: " + numberOfDigits);