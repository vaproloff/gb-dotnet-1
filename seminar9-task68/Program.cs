//=======================================================
// # 68 Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
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

// Метод, принимает числа M и N, вычисляет функцию Акермана для этих чисел
int Akerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Akerman(m - 1, 1);
    return Akerman(m - 1, Akerman(m, n - 1));
}

int inputM = ReadData("Введите число M: ");
int inputN = ReadData("Введите число N: ");

if (inputM >= 0 && inputN >= 0)
{
    PrintResult($"Значение функции Акермана для M={inputM} и N={inputN}: {Akerman(inputM, inputN)}");
}
else
{
    PrintResult("Введены неверные числа");
}