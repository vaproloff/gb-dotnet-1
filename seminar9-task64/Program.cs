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
    if (numN == 1) return "1"; // Точка остановки
    return numN + " " + LineGenRec(numN > 0 ? numN - 1 : numN + 1); // Изменяем на 1 в направлении 1
}

int inputNum = ReadData("Введите число: ");
PrintResult(LineGenRec(inputNum));