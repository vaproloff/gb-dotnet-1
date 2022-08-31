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
    int inputNumberA = int.Parse(inputLineA); // Преобразование входных данных в целое число
    int inputNumberB = int.Parse(inputLineB);

    // Вариант решения 1
    // string answerMax = ""; // Заводим строковую переменную

    // if (inputNumberA == inputNumberB) // Проверяем на равенство двух чисел
    // {
    //     answerMax = "Два числа равны между собой"; // Сохраняем ответ
    // }
    // else
    // {
    //     string maxNumberA = "Число " + inputNumberA + " больше, чем число " + inputNumberB; // Подготовили строку с первым ответом
    //     string maxNumberB = "Число " + inputNumberB + " больше, чем число " + inputNumberA; // Подготовили строку со вторым ответом
    //     answerMax = inputNumberA > inputNumberB ? maxNumberA : maxNumberB; // Сохраняем ответ в зависимости от чисел
    // }

    // Console.WriteLine(answerMax); // Вывод ответа в консоль
    // =================

    // Вариант решения 2
    if (inputNumberA > inputNumberB) // Проверяем какое из чисел больше
    {
        Console.WriteLine("Число " + inputNumberA + " больше, чем число " + inputNumberB); // Вывод ответа в консоль
    }
    else if (inputNumberA < inputNumberB) // Проверяем какое из чисел больше
    {
        Console.WriteLine("Число " + inputNumberB + " больше, чем число " + inputNumberA); // Вывод ответа в консоль
    }
    else // Если числа равны
    {
        Console.WriteLine("Два числа равны между собой"); // Вывод ответа в консоль
    }
    // =================
}