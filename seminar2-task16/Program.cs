//=======================================================
// # 16 Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого.
//=======================================================

// Метод, запрашивающий у пользователя i-е число
string AskForNumber(int number)
{
    Console.Write("Введите " + number + "-е число: ");
    string? inputLine = Console.ReadLine();

    int inputNumber = 0;

    if (inputLine != null)
    {

        return inputLine;
    }
    else
    {
        return null;
    }
}

bool checkIfNumberIsSquare(int firstNumber, int secondNumber)
{
    return (firstNumber == Math.Pow(secondNumber, 2)) || (secondNumber == Math.Pow(firstNumber, 2));
}

void findIfOneNumberIsSquareOfAnother()
{
    string inputLineA = AskForNumber(1);
    string inputLineB = AskForNumber(2);
    int inputNumberA, inputNumberB;

    if (int.TryParse(inputLineA, out inputNumberA) && int.TryParse(inputLineB, out inputNumberB))
    {
        Console.WriteLine(checkIfNumberIsSquare(inputNumberA, inputNumberB) ?
            "Одно число является квадратом другого" :
            "Ни одно число не является квадратом другого");
    }
    else
    {
        Console.Write("Это не числа");
    }
}

findIfOneNumberIsSquareOfAnother();