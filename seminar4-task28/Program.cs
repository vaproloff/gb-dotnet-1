//=======================================================
// # 28 Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
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

// Метод вычисления факториала циклом
long CalculateFactorialCycle(int num)
{
    long factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}

// Метод вычисления факториала рекурсией
long CalculateFactorialRecursive(int num)
{
    if (num == 1)
        return 1;
    return num * CalculateFactorialRecursive(num - 1);
}

int number = ReadData("Введите число: ");
long factorial = CalculateFactorialCycle(number);
long factorialRecursive = CalculateFactorialRecursive(number);
PrintResult("Факториал циклом: " + factorial);
PrintResult("Факториал рекурсией: " + factorialRecursive);