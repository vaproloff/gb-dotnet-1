//=======================================================
// # 67 Напишите программу, которая принимает на вход число,
// возвращает сумму его цифр.
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

// Метод, принимает число, сумму цифр этого числа
int RecSumDigit(int num)
{
    if (num == 0) return 0;
    return num % 10 + RecSumDigit(num / 10);
}

int inputNum = ReadData("Введите число: ");
PrintResult(RecSumDigit(inputNum) + "");