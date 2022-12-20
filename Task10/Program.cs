/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*
Алгоритм
Ввести трёхзначное число с проверкой  от "балбеса"
Произвести деление на 10 без остатка (/)
Результат разделить на 10 с остатком (%)
Вывести результат в консоли
*/

int GetNumberFromConsole(string message)
{
    int result = 0;
    while(true)
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

Console.WriteLine("Введите трёхзначное число: ");

//string NumberStr = Console.ReadLine() ?? "";
int number = GetNumberFromConsole("");

if(number >= 100 && number < 1000)
{
    int num = number / 10;
    int num2 = num % 10;

    //Console.WriteLine($"{Number} --> {num2}");
    Console.WriteLine($" {num2}");
}
else
{
    Console.WriteLine("Это не трёхзначное число!");
}