//=======================================================
// # Дополнительно: Написать программу которая из имен
// через запятую выберет случайное имя и выведет в терминал.
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

// Метод, принимает список имён строкой, возвращает случайное имя из списка
string ChooseName(string nameList)
{
    // Преобразуем строку в массив строк, разделяя элементы запятой
    string[] nameArray = nameList.Split(",");

    // Возвращаем случайный элемент массива, убирая пробелы по краям если имеются
    return nameArray[new Random().Next(0, nameArray.Length)].Trim(' ');
}

string inputLine = ReadData("Введите список имён через запятую: ");

PrintResult(ChooseName(inputLine));