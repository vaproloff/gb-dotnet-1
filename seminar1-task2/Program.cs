//=======================================================
// # 2 Напишите программу, которая на вход принимает два
// числа и выдаёт, какое число большее, а какое меньшее. 
//=======================================================

Console.Write("Введите первое число: ");
string? inputLineA = Console.ReadLine();
Console.Write("Введите второе число: ");
string? inputLineB = Console.ReadLine();

if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    // Вариант решения 1
    // string answerMax = "";

    // if (inputNumberA == inputNumberB)
    // {
    //     answerMax = "Два числа равны между собой";
    // }
    // else
    // {
    //     string maxNumberA = "Число " + inputNumberA + " больше, чем число " + inputNumberB;
    //     string maxNumberB = "Число " + inputNumberB + " больше, чем число " + inputNumberA;
    //     answerMax = inputNumberA > inputNumberB ? maxNumberA : maxNumberB;
    // }

    // Console.WriteLine(answerMax);
    // =================

    // Вариант решения 2
    if (inputNumberA > inputNumberB)
    {
        Console.WriteLine("Число " + inputNumberA + " больше, чем число " + inputNumberB);
    }
    else if (inputNumberA < inputNumberB)
    {
        Console.WriteLine("Число " + inputNumberB + " больше, чем число " + inputNumberA);
    }
    else
    {
        Console.WriteLine("Два числа равны между собой");
    }
    // =================
}