//=======================================================
// # 22 Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел от 1 до N.
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

// Метод, принимает число N и степень, возвращает строку чисел от 1 до N в этой степени
string LineNumbers(int numberN, int pow)
{
    string outLine = string.Empty;

    // Вариант цикла while
    // int i = 1;
    // while (i < numberN)
    // {
    //     outLine = outLine + Math.Pow(i, pow) + "\t";
    //     ++i;
    // }
    // outLine = outLine + Math.Pow(numberN, pow);

    // Вариант цикла for
    for (int i = 1; i <= numberN; i++)
    {
        outLine = outLine + Math.Pow(i, pow) + "\t";
    }

    return outLine;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число N: ");

PrintResult(LineNumbers(num, 1));
PrintResult(LineNumbers(num, 2));