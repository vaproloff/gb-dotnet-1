//=======================================================
// # 63 Напишите программу, которая выдаёт все натуральные
// числа в промежутке от 1 до N
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

// Метод, число N, возвращает строку чисел от 1 до N
string LineGenRec(int numN)
{
    if (numN == 0) return ""; //Точка остановки
    string outline = LineGenRec(numN - 1) + " " + numN;
    return outline;
}

int inputNum = ReadData("Введите число: ");
PrintResult(LineGenRec(inputNum));