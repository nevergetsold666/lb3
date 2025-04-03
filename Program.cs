
Console.WriteLine("Serdiuk Danil");
//Завдання 1

Console.Write("Введіть ціле число: ");
if (int.TryParse(Console.ReadLine(), out int number))
 {
    string parity = (number % 2 == 0) ? "парне" : "непарне";
    string sign = (number > 0) ? "додатнє" : (number < 0) ? "від'ємне" : "нуль";
    Console.WriteLine($"Число {number} є {parity} і {sign}.");
}
else
 {
    Console.WriteLine("Неправильне введення!");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Завдання 2
Console.Write("Введіть перше число: ");
if (!double.TryParse(Console.ReadLine(), out double num1))
{
    Console.WriteLine("Неправильне введення!");
    return;
}

Console.Write("Введіть друге число: ");
if (!double.TryParse(Console.ReadLine(), out double num2))
{
    Console.WriteLine("Неправильне введення!");
    return;
}

Console.Write("Оберіть операцію (+, -, *, /): ");
char operation = Console.ReadKey().KeyChar;
Console.WriteLine();

double result;
switch (operation)
{
    case '+':
        result = num1 + num2;
        Console.WriteLine($"Результат: {num1} + {num2} = {result}");
        break;
    case '-':
        result = num1 - num2;
        Console.WriteLine($"Результат: {num1} - {num2} = {result}");
        break;
    case '*':
        result = num1 * num2;
        Console.WriteLine($"Результат: {num1} * {num2} = {result}");
        break;
    case '/':
        if (num2 != 0)
        {
            result = num1 / num2;
            Console.WriteLine($"Результат: {num1} / {num2} = {result}");
        }
        else
        {
            Console.WriteLine("Помилка: ділення на нуль!");
        }
        break;
    default:
        Console.WriteLine("Неправильна операція!");
        break;
}


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


//Завдання 3
int G, S;
try
{
    Console.Write("Введіть годину: ");
    G = int.Parse(Console.ReadLine());
    Console.Write("Введіть хвилини: ");
    S = int.Parse(Console.ReadLine());
    if (G > 23 || G < 0 || S < 0 || S > 59)
    {
        Console.WriteLine("Неправильне введення");
        return;
    }
    Console.WriteLine($"Формат 24 {G}:{S}");
    string T = "AM";
    if (G > 12)
    {
        G = G - 12;
        T = "PM";
    }
    if (G == 0)
    {
        G = 12;
        T = "PM";
    }
    Console.WriteLine($"Формат 12 {G}:{S} {T}");
}
catch (Exception K)
{
    Console.WriteLine(K.Message);
}


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


//Завдання 4
try
{
    Console.Write("Введіть сторону a: ");
    double a = double.Parse(Console.ReadLine());

    Console.Write("Введіть сторону b: ");
    double b = double.Parse(Console.ReadLine());

    Console.Write("Введіть сторону c: ");
    double c = double.Parse(Console.ReadLine());

    if (a + b > c && a + c > b && b + c > a)
    {
        double p = (a + b + c) / 2;
        double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        Console.WriteLine($"Трикутник існує. Його площа: {s:F2}");
    }
    else
    {
        Console.WriteLine("Трикутник не існує!");
    }
}
catch (Exception)
{
    Console.WriteLine("Неправильне введення!");
}
