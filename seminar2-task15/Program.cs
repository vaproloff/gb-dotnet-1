//=======================================================
// # 15 Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
//=======================================================

// Словарь, содержащий название дней недели в соответствии с их номерами
Dictionary<int, string> daysOfWeek = new Dictionary<int, string>
{
    {1, "Понедельник"},
    {2, "Вторник"},
    {3, "Среда"},
    {4, "Четверг"},
    {5, "Пятница"},
    {6, "Суббота"},
    {7, "Воскресенье"}
};

// Словарь, содержащий номера дней недели и выходные ли они
Dictionary<int, bool> weekends = new Dictionary<int, bool>
{
    {1, false},
    {2, false},
    {3, false},
    {4, false},
    {5, false},
    {6, true},
    {7, true}
};

// Метод, запрашивающий у пользователя данные
int AskForData()
{
    Console.Write("Введите номер дня недели: ");
    string? inputLine = Console.ReadLine();

    int inputNumber = 0;

    // Проверка на ввод текста или null, если число - преобразует
    if (int.TryParse(inputLine, out inputNumber))
    {
        return inputNumber;
    }
    else
    {
        return 0;
    }
}

// Метод, вызывает метод запроса числа, проверяет день недели, выводит результат
void findIfInputDayIsWeekend()
{
    int dayNumber = AskForData();

    // Проверка на вхождение значения в словарь, при успехе - запись в переменную
    if (daysOfWeek.ContainsKey(dayNumber))
    {
        Console.WriteLine(daysOfWeek[dayNumber] + " - " + (weekends[dayNumber] ? "выходной день" : "будний день"));
    }
    else
    {
        Console.WriteLine("Это не номер дня недели");
    }
}

findIfInputDayIsWeekend();