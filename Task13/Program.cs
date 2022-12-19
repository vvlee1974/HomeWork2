/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
/*

/*
АЛГОРИТМ
Ввести любое число с проверкой от "балбеса"
Определяем массив для деления
Выводим сообщение при введении числа меньше 100
Запускаем цикл нахождения количества цифр в введённом числе
Определить количество цифр в числе слева
Определить количество цифр в числе справа
Выводим результат в консоль

*/



int GetNumberFromConsole(string message)
{
    int num = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out num))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число!");
        }
    }
    return num;
}

Console.WriteLine("Введите любое число: ");

int number = GetNumberFromConsole("");

            //  0   1   2    3      4       5       6        7         8
int[] array = { 1, 10, 100, 1000, 10000, 100000, 1000000, 10000000, 100000000 };
int n = array.Length;

int index = 0;


if (number < 100)
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    while (index < n)
    {
        if (number < array[index])
        {
            int a = index; // int a - количество цифр в введённом числе
            // Console.WriteLine(a); Проверка правильности подсчёта введённого числа
            int indexLeft = a - 2; // определяем третью цифру слева
            int indexRigth = a - 3; // определяем третью цифру справа
            int digNum = (number % array[indexLeft]) / array[indexRigth];
            Console.Write($"Третья цифра  ->  {digNum}");
            break;
        }
        index++;

    }
}

//              ПЕРВОНАЧАЛЬНЫЙ ВАРИАНТ

/*
int a = 1;
int indexLeft = a - 3; // определяем третью цифру слева
int indexRigth = a - 2; // определяем третью цифру справа

if (number < 100)
{
    Console.WriteLine("Нет третьей цифры");
}
else if (number < 1000)
{
    a = 3; // количество цифр в введённом числе
    indexLeft = a - 2;
    indexRigth = a - 3;

    int digNum = (number % array[indexLeft]) / array[indexRigth];
    Console.Write(digNum);
}
else if (number < 10000)
{
    a = 4;
    indexLeft = a - 2;
    indexRigth = a - 3;

    int digNum = (number % array[indexLeft]) / array[indexRigth];
    Console.Write(digNum);
}
else if (number < 100000)
{
    a = 5;
    indexLeft = a - 2;
    indexRigth = a - 3;

    int digNum = (number % array[indexLeft]) / array[indexRigth];
    Console.Write(digNum);
}
else if (number < 1000000)
{
    a = 6;
    indexLeft = a - 2;
    indexRigth = a - 3;

    int digNum = (number % array[indexLeft]) / array[indexRigth];
    Console.Write(digNum);
}
else if (number < 10000000)
{
    a = 7;
    indexLeft = a - 2;
    indexRigth = a - 3;

    int digNum = (number % array[indexLeft]) / array[indexRigth];
    Console.Write(digNum);
}
else if (number < 100000000)
{
    a = 8;
    indexLeft = a - 2;
    indexRigth = a - 3;

    int digNum = (number % array[indexLeft]) / array[indexRigth];
    Console.Write(digNum);
}
else if (number < 1000000000)
{
    a = 9;
    indexLeft = a - 2;
    indexRigth = a - 3;

    int digNum = (number % array[indexLeft]) / array[indexRigth];
    Console.Write(digNum);
}
*/
