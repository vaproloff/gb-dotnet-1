//=======================================================
// # 41* Пользователь вводит число нажатий, затем программа
// следит за нажатиями и выдает сколько чисел больше 0 было введено.
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

// Метод, обрабатывающий заданное количество нажатий, возвращает количество введенных положительных чисел их набора нажатий
int CountPositives(int keypresses)
{
    // Вводим счётчик положительных чисел, накапливаемое число, накапливаемую строку для обработки
    int positiveNum = 0;
    int collectedNumber = 0;
    string input = "";

    Console.Write("Вводите символы на клавиатуре: ");

    // В цикле обрабатываем нажатия
    for (int i = 0; i < keypresses; i++)
    {
        ConsoleKeyInfo keyPressed = Console.ReadKey();

        // Если накопленная строка парсится в число, обновляем накопленное число
        if (int.TryParse((input + keyPressed.KeyChar), out int inputNumber))
        {
            input += keyPressed.KeyChar;
            collectedNumber = inputNumber;
        }
        // Если введен нецифровой символ - проверяем накопленное число на положительное, сбрасываем строку и число
        else
        {
            if (collectedNumber > 0) positiveNum++;
            collectedNumber = 0;
            input = "";
        }

        // Если введен минус на обычной или цифровой клавиатуре - добавляем его в обнулённую строку
        if (keyPressed.Key == ConsoleKey.Subtract || keyPressed.Key == ConsoleKey.OemMinus)
        {
            input += keyPressed.KeyChar;
        }
    }

    // Последняя проверка, если последним символом был цифровой
    if (collectedNumber > 0) positiveNum++;

    Console.WriteLine();
    return positiveNum;
}

int inputKeypresses = 0;
string inputLineKeypresses = ReadData("Введите количество нажатий клавиатуры: ");

// Если введенная строка преобразуется в число - сохраняем в переменную.
if (int.TryParse(inputLineKeypresses, out inputKeypresses))
{
    PrintResult($"Введено положительных чисел: {CountPositives(inputKeypresses)}");
}
else
{
    Console.WriteLine("Это не число");
}