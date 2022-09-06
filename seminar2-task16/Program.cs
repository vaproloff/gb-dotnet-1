//=======================================================
// # 16 Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого.
//=======================================================

// // Метод, запрашивающий у пользователя i-е число
// string AskForNumber(int number)
// {
//     Console.Write("Введите " + number + "-е число: ");
//     string? inputLine = Console.ReadLine() ?? "";
//     return inputLine;
// }

// bool checkIfNumberIsSquare(int firstNumber, int secondNumber)
// {
//     return (firstNumber == Math.Pow(secondNumber, 2)) || (secondNumber == Math.Pow(firstNumber, 2));
// }

// void findIfOneNumberIsSquareOfAnother()
// {
//     string inputLineA = AskForNumber(1);
//     string inputLineB = AskForNumber(2);
//     int inputNumberA, inputNumberB;

//     if (int.TryParse(inputLineA, out inputNumberA) && int.TryParse(inputLineB, out inputNumberB))
//     {
//         Console.WriteLine(checkIfNumberIsSquare(inputNumberA, inputNumberB) ?
//             "Одно число является квадратом другого" :
//             "Ни одно число не является квадратом другого");
//     }
//     else
//     {
//         Console.Write("Это не числа");
//     }
// }

// findIfOneNumberIsSquareOfAnother();

int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Тест на квадрат
bool SqrTest(int firstNum, int secondNum)
{
    if (firstNum == secondNum * secondNum)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void PrintData(int firstNum, int secondNum)
{
    if (SqrTest(firstNum, secondNum))
    {
        Console.WriteLine("Число " + firstNum + " - квадрат числа " + secondNum);
    }
    else
    {
        Console.WriteLine("Число " + firstNum + " - не квадрат числа " + secondNum);
    }
}

int num1 = ReadData("Введите число 1: ");
int num2 = ReadData("Введите число 2: ");
PrintData(num1, num2);
PrintData(num2, num1);