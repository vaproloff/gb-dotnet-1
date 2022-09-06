//=======================================================
// # 19 Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.
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

// Способ 1. Определение палиндрома для пятизначного числа
// Метод, определяющий палиндром
// bool CheckIfPalindrom(int inputNumber)
// {
//     // Сравниваем 1 и 5 цифры и 2 и 4 цифры
//     if ((inputNumber / 10000 == inputNumber % 10) &&
//         ((inputNumber / 1000) % 10 == (inputNumber % 100) / 10))
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// int inputNumber = 0;
// string inputLine = ReadData("Введите пятизначное число: ");
// if (int.TryParse(inputLine, out inputNumber))
// {
//     if (inputNumber > 9999 && inputNumber < 100000)
//     {
//         PrintResult(CheckIfPalindrom(inputNumber) ? "Это палиндром" : "Это не палиндром");
//     }
//     else
//     {
//         PrintResult("Это не пятизначное число");
//     }
// }
// else
// {
//     PrintResult("Это не число");
// }

//=======================================================

// Способ 2. Определение палиндрома для любого целого числа
// Метод, определяющий палиндром
// bool CheckIfPalindrom(int inputNumber)
// {
//     // Преобразовываем число в массив символов
//     char[] numArray = inputNumber.ToString().ToCharArray();
//     string reverseNumber = "";

//     // Цикл, переворачивающий массив символом в обратном порядке
//     for (int i = 0; i < numArray.Length; i++)
//     {
//         reverseNumber = reverseNumber + numArray[numArray.Length - 1 - i];
//     }

//     // Сравнение исходного числа с перевёрнутым
//     return int.Parse(reverseNumber) == inputNumber;
// }

// int inputNumber = 0;
// string inputLine = ReadData("Введите целое число: ");
// if (int.TryParse(inputLine, out inputNumber))
// {
//     PrintResult(CheckIfPalindrom(inputNumber) ? "Это палиндром" : "Это не палиндром");
// }
// else
// {
//     PrintResult("Это не число");
// }

//=======================================================

// Способ 3. Определение палиндрома для пятизначного числа с помощью словаря
// Метод, возвращающий словарь четырехзначных палиндромов
Dictionary<int, int> FillPalindroms()
{
    Dictionary<int, int> palindroms = new Dictionary<int, int>();

    // Цикл внутри цикла, заполняющих значения словаря палиндромов
    for (int i = 1; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            int key = j * 10 + i;
            int value = i * 1000 + j * 100 + j * 10 + i;
            palindroms.Add(key, value);
        }
    }

    return palindroms;
}

// Метод, проверяющий на палиндром
bool CheckIfPalindrom(int inputNumber, Dictionary<int, int> palindroms)
{
    // Делаем из исходного пятизначного числа четырёхзначное, убирая третью цифру
    int fourDigitNumber = (inputNumber / 1000) * 100 + inputNumber % 100;
    // Проверка на вхождение в словарь палиндромов
    return palindroms.ContainsValue(fourDigitNumber);
}

int inputNumber = 0;
string inputLine = ReadData("Введите пятизначное число: ");
if (int.TryParse(inputLine, out inputNumber))
{
    if (inputNumber > 9999 && inputNumber < 100000)
    {
        Dictionary<int, int> fourDigitPalindroms = FillPalindroms();
        PrintResult(CheckIfPalindrom(inputNumber, fourDigitPalindroms) ? "Это палиндром" : "Это не палиндром");
    }
    else
    {
        PrintResult("Это не пятизначное число");
    }
}
else
{
    PrintResult("Это не число");
}