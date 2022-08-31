//=======================================================
// # 4 Напишите программу, которая принимает на вход
// три числа и выдаёт максимальное из этих чисел.
//=======================================================


Console.Write("Введите первое число: ");
string? inputLineA = Console.ReadLine();
Console.Write("Введите второе число: ");
string? inputLineB = Console.ReadLine();
Console.Write("Введите третье число: ");
string? inputLineC = Console.ReadLine();

if (inputLineA != null && inputLineB != null && inputLineC != null) // Проверяем входные данные на null
{
    // Вариант решения 1
    // int[] inputNumbers = new int[] { int.Parse(inputLineA), int.Parse(inputLineB), int.Parse(inputLineC) }; // Вводим массив преобразованных в целые числа вводных данных

    // int maxNumber = inputNumbers[0]; // Вводим переменную для хранения максимального числа, присваиваем первый элемент массива трёх чисел

    // for (int i = 1; i < inputNumbers.Length; i++)// Пробегаем по массиву, начиная со второго элемента
    // {
    //     if (inputNumbers[i] > maxNumber) maxNumber = inputNumbers[i]; // Если текущий элемент массива больше текущего максимального, то задаём новый максимум
    // }

    // Console.WriteLine("Максимальное число: " + maxNumber); // Выводим ответ
    // =================

    // Вариант решения 2
    // int inputNumberA = int.Parse(inputLineA); // Преобразование входных данных в целое число
    // int inputNumberB = int.Parse(inputLineB);
    // int inputNumberC = int.Parse(inputLineC);

    // int maxNumber = inputNumberA; // Вводим переменную для хранения максимального числа, присваиваем первое число
    // if (inputNumberB > maxNumber) maxNumber = inputNumberB; // Если второе число больше текущего максимального, то второе число - новый максимум
    // if (inputNumberC > maxNumber) maxNumber = inputNumberC; // Если третье число больше текущего максимального, то третье число - новый максимум

    // Console.WriteLine("Максимальное число: " + maxNumber); // Выводим ответ
    // =================

    // Вариант решения 3 - с тернарным оператором
    // int inputNumberA = int.Parse(inputLineA); // Преобразование входных данных в целое число
    // int inputNumberB = int.Parse(inputLineB);
    // int inputNumberC = int.Parse(inputLineC);

    // int maxNumber = inputNumberA > inputNumberB ?
    //     (inputNumberA > inputNumberC ? inputNumberA : inputNumberC) :
    //     (inputNumberB > inputNumberC ? inputNumberB : inputNumberC);
    // Console.WriteLine("Максимальное число: " + maxNumber); // Выводим ответ
    // =================

    // Вариант решения 4 - с Math.Max
    int inputNumberA = int.Parse(inputLineA); // Преобразование входных данных в целое число
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberC = int.Parse(inputLineC);

    Console.WriteLine("Максимальное число: " + Math.Max(Math.Max(inputNumberA, inputNumberB), inputNumberC)); // Выводим ответ
    // =================
}