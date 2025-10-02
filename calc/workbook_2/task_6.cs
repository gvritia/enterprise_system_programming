// №6
// Лабораторный опыт
// В чашку Петри кладут N бактерий и добавляют X капель
// антибиотика (N и X вводятся с клавиатуры).
//     Известно, что число бактерий в чашке Петри увеличивается в два
//     раза каждый час, а каждая капля антибиотика в первый час убивает 10
// бактерий, во второй час — 9 бактерий, в следующий — 8 и так далее,
//     пока антибиотик не перестанет действовать. Заметьте, что сначала число
// бактерий увеличивается, а затем только действует антибиотик.
//     Пользователь вашей программы вводит N и X, а программа
//     печатает на экране, сколько бактерий останется в чашке Петри в конце
// каждого часа, до тех пор, пока не закончатся бактерии или антибиотик
//     не перестанет действовать.
//     Цикл не должен быть бесконечным (после того как количество
// антибиотики или бактерий становиться равным нулю выполнение
//     программы должно быть завершено).


using System;

class Program
{
    static void Main()
    {
        // Заранее заданные значения для тестирования
        int initialBacteria = 12;
        int antibioticDrops = 1;
        
        Console.WriteLine($"Начальное количество бактерий: {initialBacteria}");
        Console.WriteLine($"Количество капель антибиотика: {antibioticDrops}");
        Console.WriteLine("=================================");
        
        SimulateExperiment(initialBacteria, antibioticDrops);
    }
    
    static void SimulateExperiment(int bacteria, int antibioticDrops)
    {
        int hour = 0;
        int currentAntibioticPower = 10; // Начальная сила антибиотика
        
        while (bacteria > 0 && antibioticDrops > 0 && currentAntibioticPower > 0)
        {
            hour++;
            
            // Бактерии размножаются
            bacteria *= 2;
            
            // Действие антибиотика
            int bacteriaKilled = Math.Min(bacteria, currentAntibioticPower);
            bacteria -= bacteriaKilled;
            
            // Уменьшаем силу антибиотика для следующего часа
            currentAntibioticPower--;
            
            // Если антибиотик полностью израсходовал свою силу, уменьшаем количество капель
            if (currentAntibioticPower <= 0)
            {
                antibioticDrops--;
                currentAntibioticPower = 10; // Новая капля начинает с силы 10
            }
            
            Console.WriteLine($"После {hour} часа бактерий осталось {bacteria}");
            
            // Если бактерии закончились
            if (bacteria <= 0)
            {
                Console.WriteLine("Все бактерии уничтожены!");
                break;
            }
            
            // Если антибиотик закончился
            if (antibioticDrops <= 0)
            {
                Console.WriteLine("Антибиотик перестал действовать!");
                break;
            }
        }
    }
}