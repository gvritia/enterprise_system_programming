// №5
// Кофейный аппарат
// Кофейный аппарат может готовить два напитка: американо и латте.
//     Для американо требуется 300 мл воды (цена 150 рублей), а для латте 30
// мл воды и 270 мл молока (цена 170 рублей).
// Напишите программу, которая спрашивает у пользователя (это
// действие программа делает один раз в начале работы), сколько всего
// 9
// миллилитров молока и воды залито в кофейный аппарат.
//     После чего начинает обслуживание пользователей, запрашивается,
//     какой напиток хочет заказать посетитель. Пользователь выбирает один
//     из двух напитков, программа отвечает одним из трёх вариантов: «Ваш
//     напиток готов», «Не хватает воды» или «Не хватает молока», после чего
// переходит к обслуживанию следующего посетителя. Если молока и воды
// не хватает ни на один вид напитка, программа выдаёт отчёт и
// завершается.
//     В отчёте должно быть написано, что ингредиенты подошли к
//     концу, должен быть указан остаток воды и молока в машине, должно
// быть указано, сколько всего было приготовлено чашек американо и латте
//     за эту смену и итоговый заработок аппарата. 


using System;

class Program
{
    static void Main()
    {
        // Заранее заданные начальные запасы
        int water = 1000;  // мл
        int milk = 1500;   // мл
        
        // Счётчики проданных напитков
        int americanoCount = 0;
        int latteCount = 0;
        
        // Заранее заданные заказы для тестирования
        int[] orders = { 2, 1, 2, 1, 2, 1, 2, 1 }; // 1 - американо, 2 - латте
        
        Console.WriteLine("Кофейный аппарат");
        Console.WriteLine($"Начальные запасы: Вода - {water} мл, Молоко - {milk} мл");
        Console.WriteLine("==================================");
        
        foreach (int order in orders)
        {
            // Проверяем, можно ли приготовить хотя бы один напиток
            if (!CanMakeAmericano(water) && !CanMakeLatte(water, milk))
            {
                Console.WriteLine("\nИнгредиенты закончились!");
                break;
            }
            
            if (order == 1) // Американо
            {
                if (CanMakeAmericano(water))
                {
                    water -= 300;
                    americanoCount++;
                    Console.WriteLine("Заказ: Американо - Ваш напиток готов");
                }
                else
                {
                    Console.WriteLine("Заказ: Американо - Не хватает воды");
                }
            }
            else if (order == 2) // Латте
            {
                if (CanMakeLatte(water, milk))
                {
                    water -= 30;
                    milk -= 270;
                    latteCount++;
                    Console.WriteLine("Заказ: Латте - Ваш напиток готов");
                }
                else if (water < 30)
                {
                    Console.WriteLine("Заказ: Латте - Не хватает воды");
                }
                else
                {
                    Console.WriteLine("Заказ: Латте - Не хватает молока");
                }
            }
            
            Console.WriteLine($"Остаток: Вода - {water} мл, Молоко - {milk} мл");
            Console.WriteLine("---");
        }
        
        // Вывод отчёта
        PrintReport(water, milk, americanoCount, latteCount);
    }
    
    static bool CanMakeAmericano(int water)
    {
        return water >= 300;
    }
    
    static bool CanMakeLatte(int water, int milk)
    {
        return water >= 30 && milk >= 270;
    }
    
    static void PrintReport(int water, int milk, int americanoCount, int latteCount)
    {
        Console.WriteLine("\n" + new string('*', 40));
        Console.WriteLine("ОТЧЁТ");
        Console.WriteLine("Ингредиентов осталось:");
        Console.WriteLine($"Вода: {water} мл");
        Console.WriteLine($"Молоко: {milk} мл");
        Console.WriteLine($"Кружек американо приготовлено: {americanoCount}");
        Console.WriteLine($"Кружек латте приготовлено: {latteCount}");
        
        int totalRevenue = (americanoCount * 150) + (latteCount * 170);
        Console.WriteLine($"Итого: {totalRevenue} рублей");
        Console.WriteLine(new string('*', 40));
    }
}