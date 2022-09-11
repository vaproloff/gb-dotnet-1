//=======================================================
// # 25* Написать калькулятор с операциями
// +, -, /, * и возведение в степень.
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

// Метод вычисления суммы двух чисел
double CalculateSum(double numA, double numB)
{
    return numA + numB;
}

// Метод вычисления разности двух чисел
double CalculateDiff(double numA, double numB)
{
    return numA - numB;
}

// Метод вычисления произведения двух чисел
double CalculateProd(double numA, double numB)
{
    return numA * numB;
}

// Метод вычисления частного двух чисел
double CalculateDiv(double numA, double numB)
{
    return numA / numB;
}

// Метод возведения в степень
double CalculatePow(double numA, double numB)
{
    return Math.Pow(numA, numB);
}

// Метод, принимает два числа и оператор, считает и печатает результат
void CalculateAndPrint(double numA, double numB, string mathOperator)
{
    string resultLine = $"{numA} {mathOperator} {numB} = ";

    // Вызываем нужный метод в зависимости от оператора и выводим в консоль
    switch (mathOperator)
    {
        case "+":
            PrintResult(resultLine + CalculateSum(numA, numB));
            break;
        case "-":
            PrintResult(resultLine + CalculateDiff(numA, numB));
            break;
        case "*":
            PrintResult(resultLine + CalculateProd(numA, numB));
            break;
        case "/":
            PrintResult(resultLine + CalculateDiv(numA, numB));
            break;
        case "^":
            PrintResult(resultLine + CalculatePow(numA, numB));
            break;
        default:
            PrintResult($"Оператор {mathOperator} не поддерживается");
            break;
    }
}

double inputNumberA, inputNumberB;
string inputLineA = ReadData("Введите число A: ");
string inputLineOperator = ReadData("Введите оператор (+, -, *, /, ^): ");
string inputLineB = ReadData("Введите число B: ");

if (double.TryParse(inputLineA, out inputNumberA) && double.TryParse(inputLineB, out inputNumberB))
{
    CalculateAndPrint(inputNumberA, inputNumberB, inputLineOperator);
}
else
{
    PrintResult("Числа введены неверно");
}