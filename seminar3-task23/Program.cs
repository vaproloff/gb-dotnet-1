//=======================================================
// # 23 Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
//=======================================================

// Метод считывания данных пользователя
string ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Возвращаем считанное значение
    return Console.ReadLine() ?? "";
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Стандартное решение. Построчный вывод таблицы кубов с табуляцией
// // Метод, принимает число N и степень, возвращает строку чисел от 1 до N в этой степени
// string LineNumbers(int numberN, int pow)
// {
//     string outLine = string.Empty;

//     for (int i = 1; i <= numberN; i++)
//     {
//         outLine = outLine + Math.Pow(i, pow) + "\t";
//     }

//     return outLine;
// }

// int inputNumber = 0;
// string inputLine = ReadData("Введите число N: ");

// if (int.TryParse(inputLine, out inputNumber))
// {
//     PrintResult(LineNumbers(inputNumber, 1));
//     PrintResult(LineNumbers(inputNumber, 3));
// }
// else
// {
//     PrintResult("Это не число");
// }

//=======================================================

// Решение "со звёздочкой". Строим таблицу с разделителями и равными ячейками
// Метод, принимает число N, степень, кол-во колонок таблицы, выводит таблицу в консоль
void MakePowTable(int numberN, int pow, int columns)
{
    int count = 1;
    // Считаем размер ячейки (без учета разделителей, с учётом пробелов по бокам)
    int cellSize = (Math.Pow(numberN, pow) + "").Length + 2;

    // Выводим верхнюю границу таблицы
    PrintResult(MakeMonoString("-", (cellSize + 1) * columns + 1));

    // Общий цикл от 1 до N
    while (count <= numberN)
    {
        // Инициализируем две строки: для чисел и для кубов этих чисел
        string outLine = "";
        string outLinePow = "";

        // Цикл формирует строки по заданному количеству колонок таблицы
        for (int i = 0; i < columns; i++)
        {
            // Вставляем разделители
            outLine += "|";
            outLinePow += "|";

            // Проверяем, нужно ли ещё считать кубы
            if (count <= numberN)
            {
                // Формируем ячейки и дозаполняем строки 
                string numCell = " " + count + " ";
                outLine += numCell + MakeMonoString(" ", cellSize - numCell.Length);
                string powCell = " " + Math.Pow(count, pow) + " ";
                outLinePow += powCell + MakeMonoString(" ", cellSize - powCell.Length);
                count++;
            }
            else
            {
                // Формируем пустые ячейки, чтобы низ таблицы был завершённым
                outLine += MakeMonoString(" ", cellSize);
                outLinePow += MakeMonoString(" ", cellSize);
            }
        }
        // Добавляем закрывающие строки разделители
        outLine += "|";
        outLinePow += "|";

        // Выводим готовые строки и нижнюю границу
        PrintResult(outLine);
        PrintResult(outLinePow);
        PrintResult(MakeMonoString("-", (cellSize + 1) * columns + 1));
    }
}

// Метод, принимает заданный символ и количество, возвращает строку повторяющихся символов
string MakeMonoString(string symbol, int quantity)
{
    string spaces = "";
    for (int i = 0; i < quantity; i++)
    {
        spaces += symbol;
    }
    return spaces;
}

// Получаем число N
int inputNumber = 0;
string inputLine = ReadData("Введите число N: ");

// Проверяем число на текст, выполняем задачу
if (int.TryParse(inputLine, out inputNumber))
{
    // Получаем количество столбцов. Если не ввести ничего или меньше 1 - будет 10
    int columnQty;
    string inputColumns = ReadData("Количество колонок таблицы (по-умолчанию - 10): ");
    if (!int.TryParse(inputColumns, out columnQty)) columnQty = 10;
    if (columnQty < 1) columnQty = 10;

    MakePowTable(inputNumber, 3, columnQty);
    PrintResult("Если таблица не помещается в консольное окно - попробуйте снова, уменьшив при этом количество столбцов");
}
else
{
    PrintResult("Это не число");
}