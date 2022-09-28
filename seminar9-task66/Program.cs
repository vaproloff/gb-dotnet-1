//=======================================================
// # 66 Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N
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

// Метод, принимает числа M и N, возвращает сумму всех чисел от M до N включительно
int SumNumMtoN(int m, int n)
{
    if (m == n) return n; // Точка выхода, если числа сравнялись - возвращаем любое
    return m + SumNumMtoN(m < n ? m + 1 : m - 1, n); // Вычитаем или прибывляем 1 в направлении N
}

int inputM = ReadData("Введите число M: ");
int inputN = ReadData("Введите число N: ");
PrintResult($"Сумма всех чисел от {inputM} до {inputN}: {SumNumMtoN(inputM, inputN)}");