//=======================================================
// # 1 Напишите программу, которая на вход принимает два числа
// и проверяет, является ли первое число квадратов второго.
//=======================================================

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();

if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    // bool outResult = (inputNumberA * inputNumberA == inputNumberB); // Вариант 1
    // bool outResult = (inputNumberB / inputNumberA == inputNumberA); // Вариант 2
    bool outResult = (Math.Sqrt(inputNumberB) == inputNumberA); // Вариант 3

    Console.WriteLine(outResult);
}