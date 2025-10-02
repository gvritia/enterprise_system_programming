// № 2
// Счастливый билет
// Если на билете сумма первых трёх цифр в номере билета равна
//     сумме трёх последних, то этот билет считается счастливым. Напишите
//     программу, которая получала бы на вход шестизначный номер билета и
//     выводила, счастливый это билет или нет. К примеру: билеты 777 777 и
// 255 642 — счастливые, а 123 456 — нет.
//     Использовать при решении задачи можно только простые базовые
// типы (т.е. использование массивов, строк и коллекций запрещено,
//     должно обрабатываться именно число).



using System;

class Program
{
    static void Main()
    {
        // Заранее заданные номера билетов для проверки
        int[] testTickets = { 123060, 123040, 777777, 255642, 123456, 111111, 100001, 654321, 000000, 999999 };
        
        Console.WriteLine("Проверка счастливых билетов:");
        Console.WriteLine("=============================");
        
        foreach (int ticket in testTickets)
        {
            bool isLucky = IsLuckyTicket(ticket);
            Console.WriteLine($"Билет {ticket:D6} -> {isLucky}");
        }
    }
    
    static bool IsLuckyTicket(int ticket)
    {
        // Получаем отдельные цифры билета
        int digit1 = ticket / 100000;
        int digit2 = (ticket / 10000) % 10;
        int digit3 = (ticket / 1000) % 10;
        int digit4 = (ticket / 100) % 10;
        int digit5 = (ticket / 10) % 10;
        int digit6 = ticket % 10;
        
        // Сумма первых трех цифр
        int sumFirstThree = digit1 + digit2 + digit3;
        
        // Сумма последних трех цифр
        int sumLastThree = digit4 + digit5 + digit6;
        
        return sumFirstThree == sumLastThree;
    }
}