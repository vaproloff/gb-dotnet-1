//=======================================================
// # 41 Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//=======================================================

// Метод считывания данных пользователя
string ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем строку
    string inputLine = Console.ReadLine() ?? "";
    // Возвращаем значение
    return inputLine;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Метод, запрашивающий заданное количество чисел, возвращает количество положительных их них
int CountPositives(int quantity)
{
    // Вводим счётчик положительных чисел
    int positiveNum = 0;

    // В цикле запрашиваем число, парсим, проверяем положительное, увеличиваем счётчик
    for (int i = 0; i < quantity; i++)
    {
        int inputNumber = 0;
        string inputLine = ReadData($"Введите {i + 1}-е число: ");

        if (int.TryParse(inputLine, out inputNumber))
        {
            if (inputNumber > 0) positiveNum++;
        }
    }

    return positiveNum;
}

int inputQuantity = 0;
string inputLineQuantity = ReadData("Введите количество чисел: ");

// Если введенная строка преобразуется в число - сохраняем в переменную.
// Словом "out" обозначается переменная, в которую будет сохранено преобразованное из строки число, это output 
if (int.TryParse(inputLineQuantity, out inputQuantity))
{
    PrintResult($"Введено положительных чисел: {CountPositives(inputQuantity)}");
}
else
{
    Console.WriteLine("Это не число");
}