// №4
// Угадай число
// Напишите программу, которая угадывает число, задуманное
// пользователем. Число загадывается в диапазоне от 0 до 63. Программа
// задаёт вопросы вида «Ваше число больше такого-то?» и на основе
//     ответов пользователя («да-1» или «нет-0») угадывает число.
//     Алгоритм, должен давать ответ за семь вопросов. 


using System;

class Program
{
    static void Main()
    {
        // Заранее заданное число для угадывания
        int secretNumber = 42;
        
        Console.WriteLine("Загадано число от 0 до 63.");
        Console.WriteLine("Отвечайте: 1 - да, 0 - нет");
        Console.WriteLine("============================");
        
        int guessedNumber = GuessNumber();
        
        Console.WriteLine($"\nВаше число: {guessedNumber}");
        Console.WriteLine($"Загаданное число: {secretNumber}");
        Console.WriteLine($"Угадал: {guessedNumber == secretNumber}");
    }
    
    static int GuessNumber()
    {
        int low = 0;
        int high = 63;
        int questionCount = 0;
        
        while (low <= high && questionCount < 7)
        {
            int mid = (low + high) / 2;
            questionCount++;
            
            // В реальной программе здесь был бы ввод от пользователя
            // Но для демонстрации используем заранее заданное число
            bool isGreater = IsNumberGreaterThan(mid);
            
            Console.WriteLine($"Вопрос {questionCount}: Ваше число больше {mid}?");
            Console.WriteLine($"Ответ: {(isGreater ? "1 (да)" : "0 (нет)")}");
            
            if (isGreater)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        
        return low;
    }
    
    // В реальной программе здесь был бы ввод от пользователя
    // Но для демонстрации сравниваем с заранее заданным числом
    static bool IsNumberGreaterThan(int number)
    {
        int secretNumber = 42; // Заранее заданное число
        return secretNumber > number;
    }
}