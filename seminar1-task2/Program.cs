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
}