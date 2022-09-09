//=======================================================
// # 24 Напишите программу, которая принимает на вход
// число A и выдаёт сумму чисел от 1 до А.
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

// Метод, вычисления суммы чисел циклом
int VariantSumSimple(int numA)
{
    int sumOfNumbers = 0;

    for (int i = 1; i <= numA; i++)
    {
        sumOfNumbers += i;
    }

    return sumOfNumbers;
}

// Метод, вычисления суммы чисел формулой Гаусса
int VariantSumGauss(int numA)
{
    return ((1 + numA) * numA) / 2;
}

int numberA = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
int res1 = VariantSumSimple(numberA);
PrintResult("Сумма чисел простым методом: " + res1);
PrintResult("" + (DateTime.Now - d1));


DateTime d2 = DateTime.Now;
int res2 = VariantSumGauss(numberA);
PrintResult("Сумма чисел методом Гаусса: " + res2);
PrintResult("" + (DateTime.Now - d2));