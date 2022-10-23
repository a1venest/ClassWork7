//Написать рекурсивный метод деления
(int, int, int) GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return (Convert.ToInt32(Console.ReadLine()),
    Convert.ToInt32(Console.ReadLine()),
    Convert.ToInt32(Console.ReadLine()));
}

int countSets = 0;
int DivisionRemainder(int number, int divider)
{
    countSets++;
    if (number >= divider)
    {
        number -= divider;
        return DivisionRemainder(number, divider);
    }
    else return number;
}

int DivisionFull(int number, int divider)
{
    if (number >= divider)
    {
        number -= divider;
        return DivisionFull(number, divider) + 1;
    }
    else return 0;
}
// void DividingNumbers(double n1, double n2)
// {
//     double value = n1 % n2;
//     double realms = n1 / n2;
//     Console.WriteLine($"Результат деления {realms}");
//     Console.WriteLine($"Остаток {value}");
// }

// void DevNumbers(double n1, double n2)
// {
//     double temp = 0;
//     double temp2 = 0;
//     while (n1 >= n2)
//     {
//         n1 = n1 - n2;
//         temp++;
//         temp2 = n1;
//     }

//     Console.WriteLine($"результат деления равен {temp}, остаток {temp2}");
// }
var number = GetNumberFromConsole("Введите число:");
// int n = GetNumberFromConsole("Введите второе число:");
// DividingNumbers(m, n);
// DevNumbers(m, n);
// Console.WriteLine($"Результат деления: {DivisionFull(m, n)} , остаток: {DivisionRemainder(m, n)}");
// Console.WriteLine($"Количество проходов: {countSets}.");
Console.WriteLine(number.Item1);