// №1
// Ряды
//     Реализуйте программный продукт средствами языка C# со
//     следующим функционалом:
// Вычисление значения функции f(x) (соответствующей вашему
// варианту) с помощью ряда Маклорена с заданной точностью е (e и x
//     вводятся с клавиатуры, е <0.01);
// Вычисление n-го члена ряда (n и x вводятся с клавиатуры).




using System;

class Program
{
    static void Main()
    {
        // Заданные значения
        double x = 1.5;
        double epsilon = 0.001;
        int n = 5;
        
        Console.WriteLine("Вычисление гиперболического синуса sh(x) с помощью ряда Маклорена");
        Console.WriteLine($"x = {x}, точность = {epsilon}, n = {n}");
        
        // Вычисление с заданной точностью
        double result = CalculateHyperbolicSine(x, epsilon);
        double actualValue = Math.Sinh(x);
        
        Console.WriteLine($"\nРезультат с точностью {epsilon}: {result:F6}");
        Console.WriteLine($"Фактическое значение sh({x}): {actualValue:F6}");
        Console.WriteLine($"Погрешность: {Math.Abs(actualValue - result):E}");
        
        // Вычисление n-го члена ряда
        double nthTerm = CalculateNthTerm(x, n);
        Console.WriteLine($"\n{n}-й член ряда: {nthTerm:E}");
    }
    
    // Вычисление sh(x) с помощью ряда Маклорена с заданной точностью
    static double CalculateHyperbolicSine(double x, double epsilon)
    {
        double result = 0;
        double term = x; // первый член ряда (n=0)
        int n = 0;
        
        while (Math.Abs(term) >= epsilon)
        {
            result += term;
            n++;
            // Вычисляем следующий член ряда: x^(2n+1) / (2n+1)!
            term = term * x * x / ((2 * n) * (2 * n + 1));
        }
        
        return result;
    }
    
    // Вычисление n-го члена ряда Маклорена для sh(x)
    static double CalculateNthTerm(double x, int n)
    {
        // n-й член ряда: x^(2n+1) / (2n+1)!
        double numerator = 1;
        double denominator = 1;
        
        int power = 2 * n + 1;
        
        // Вычисляем x^(2n+1)
        for (int i = 0; i < power; i++)
        {
            numerator *= x;
        }
        
        // Вычисляем (2n+1)!
        for (int i = 1; i <= power; i++)
        {
            denominator *= i;
        }
        
        return numerator / denominator;
    }
}