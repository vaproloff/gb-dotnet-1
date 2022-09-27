//=======================================================
// # 64 Напишите программу, которая выдаёт все натуральные
// числа в промежутке от N до 1
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

// Метод, число N, возвращает строку чисел от N до 1
string LineGenRec(int numN)
{
    if (numN == 0) return ""; //Точка остановки
    string outline = numN + " " + LineGenRec(numN - 1);
    return outline;
}

int inputNum = ReadData("Введите число: ");
PrintResult(LineGenRec(inputNum));