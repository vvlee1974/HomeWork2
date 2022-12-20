/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

/*
АЛГОРИТМ
Ввести любое число с проверкой от "балбеса"
Вводим переменную для условия
Определяем условие с ветвлением if: вывод информации о выходных, если ввели 6 или 7
Определяем вывод информации о буднях (else if), если ввели в дипазоне 1-5
Определяем вывод информации об ошибке ввода (else), если ввели вне дипазоне 1-7
*/

int GetNumberFromConsole(string message)
{
    int result = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число!");
        }
    }
    return result;
}

Console.Write("Введите число дня недели (от 1 до 7): ");

int weekday = GetNumberFromConsole("");

if(weekday == 6 || weekday == 7)
{
    Console.WriteLine($"{weekday} -> Да");
}
else if(weekday > 0 && weekday <= 5)
{
    Console.WriteLine($"{weekday} -> Нет");
}
else
{
    Console.WriteLine("В неделе только 7 дней.");
}