//Написать рекурсивный метод деления
double GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

void DividingNumbers(double n1, double n2)
{
    double value = n1%n2;
    double realms = n1/n2;
    Console.WriteLine($"Результат деления {realms}");
    Console.WriteLine($"Остаток {value}");
}


double m = GetNumberFromConsole("Введите первое число:");
double n = GetNumberFromConsole("Введите второе число:");
DividingNumbers(m,n);