//=======================================================
// # 41* Пользователь вводит число нажатий, затем программа
// следит за нажатиями и выдает сколько чисел больше 0 было введено.
//=======================================================

using System.Text.RegularExpressions;

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

// Метод, сохраняющий последовательность нажатий в строку посимвольно
string ReadKeyString(int keypresses)
{
    string input = "";

    Console.Write("Вводите символы на клавиатуре: ");

    // В цикле обрабатываем нажатия, записываем в строку
    for (int i = 0; i < keypresses; i++)
    {
        input += Console.ReadKey().KeyChar;
    }

    return input;
}

// Метод, принимает строку, возвращает число вхождений положительных чисел
int CountPosNumbers(string rawKeyLine)
{
    // Паттерн, исключает числа, начинающиеся с минуса, включает все остальные
    Regex pattern = new Regex(@"(?<!-[0-9]*)[0-9]+");
    // Возвращаем количество соответствующих паттерну значений
    return pattern.Matches(rawKeyLine).Count;
}

int inputKeypresses = 0;
string inputLineKeypresses = ReadData("Введите количество нажатий клавиатуры: ");

// Если введенная строка преобразуется в число - сохраняем в переменную.
if (int.TryParse(inputLineKeypresses, out inputKeypresses))
{
    string rawKeyLine = ReadKeyString(inputKeypresses);
    PrintResult($"Введено положительных чисел: {CountPosNumbers(rawKeyLine)}");
}
else
{
    Console.WriteLine("Это не число");
}