// №3
// Сокращение дроби
// Пользователь вводит числа M и N. Напишите программу, которая
// преобразует дробь M/N к несократимому виду и выдаёт получившийся
// результат. 


using System;

class Program
{
    static void Main()
    {
        // Заранее заданные дроби для проверки
        (int numerator, int denominator)[] testFractions = 
        {
            (4, 6),
            (25, 40),
            (-6, 12),
            (896, 3584),
            (12, 18),
            (-15, 25),
            (7, 13),
            (0, 5),
            (100, 50)
        };
        
        Console.WriteLine("Сокращение дробей:");
        Console.WriteLine("==================");
        
        foreach (var fraction in testFractions)
        {
            SimplifyFraction(fraction.numerator, fraction.denominator);
        }
    }
    
    static void SimplifyFraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            Console.WriteLine($"Ошибка: знаменатель не может быть равен 0");
            return;
        }
        
        // Находим наибольший общий делитель (НОД)
        int gcd = FindGCD(Math.Abs(numerator), Math.Abs(denominator));
        
        // Сокращаем дробь
        int simplifiedNumerator = numerator / gcd;
        int simplifiedDenominator = denominator / gcd;
        
        // Убираем минус из знаменателя (если есть)
        if (simplifiedDenominator < 0)
        {
            simplifiedNumerator = -simplifiedNumerator;
            simplifiedDenominator = -simplifiedDenominator;
        }
        
        Console.WriteLine($"{numerator} / {denominator} -> {simplifiedNumerator} / {simplifiedDenominator}");
    }
    
    // Алгоритм Евклида для нахождения НОД
    static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}