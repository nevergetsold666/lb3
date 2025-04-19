//Завдання 1
//try
//{
//   int n;
//   Console.Write("Введіть кількість повторів (N): ");
//   n = int.Parse(Console.ReadLine());
//   for (int i = 0; i < n; i++)
//   {
//       Console.WriteLine("Сердюк Даніл");
//    }
//}
//catch (Exception K)
//{
//    Console.WriteLine(K.Message);
//}


//Завдання 2
//try
//{
//    int n;
//   Console.Write("Введіть ціле додатне число n: ");
//    n = int.Parse(Console.ReadLine());

//    int добуток = 1;

//   for (int i = 1; i <= n; i++)
//   {
//       добуток *= i;
//   }

//   Console.WriteLine("Добуток усіх чисел від 1 до n: " + добуток);
//}
//catch (Exception K)
//{ Console.WriteLine(K.Message); }


//ЗАвдання 3
//try 
//{
//  int k;
//double x, result = 1;
//Console.Write("Введіть дійсне число x: ");
//x = double.Parse(Console.ReadLine());
//Console.Write("Введіть ціле додатне число k: ");
//k = int.Parse(Console.ReadLine());
//for (int i = 0; i < k; i++)
//{
//  result *= x;
//}
//Console.WriteLine($"{x}^{k} = {result}");
//}
//catch (Exception K)
//{ Console.WriteLine(K.Message); }


//Завдання 3
//try
//{
//int number, positives = 0, negatives = 0, sum = 0;
// do
//   {
//Console.Write("Введіть число (0 — для завершення): ");
//  number = int.Parse(Console.ReadLine());
//    if (number > 0)
//      {
//positives++;
//  sum += number;
//}
//else if (number < 0)
//{
//  negatives++;
//    sum += number;
//  }
//} while (number != 0);
//Console.WriteLine("Сума введених чисел: " + sum);
//Console.WriteLine("Кількість додатних чисел: " + positives);
//  Console.WriteLine("Кількість від’ємних чисел: " + negatives);
//}
//catch (Exception K)
//{ Console.WriteLine(K.Message); }


//Завдання 5
double x = -2;
while (x <= 5)
{
    if (x + 4 > 0)
    {
        double y = Math.Sin(x) / Math.Log(x + 4);
        Console.WriteLine($"x = {x:F1}, y = {y:F4}");
    }
    else
    {
        Console.WriteLine($"x = {x:F1}, y = невизначено (log(x+4) недопустимий)");
    }
    x += 0.2;
}



