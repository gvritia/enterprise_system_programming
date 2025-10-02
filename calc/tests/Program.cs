// class SimpleCalculator
// {
//     static double memory = 0;
//     
//     static void Main()
//     {
//         Console.WriteLine("Простой калькулятор");
//         Console.WriteLine("Доступные операции: +, -, *, /, %, 1/x, x^2, sqrt, M+, M-, MR");
//         Console.WriteLine("Введите 'exit' для выхода");
//         
//         while (true)
//         {
//             Console.Write("\nВведите операцию: ");
//             string? operation = Console.ReadLine();
//             
//             if (operation.ToLower() == "exit")
//                 break;
//                 
//             ProcessOperation(operation);
//         }
//     }
//     
//     static void ProcessOperation(string operation)
//     {
//         try
//         {
//             switch (operation)
//             {
//                 case "+":
//                     Add();
//                     break;
//                 case "-":
//                     Subtract();
//                     break;
//                 case "*":
//                     Multiply();
//                     break;
//                 case "/":
//                     Divide();
//                     break;
//                 case "%":
//                     Percent();
//                     break;
//                 case "1/x":
//                     Reciprocal();
//                     break;
//                 case "x^2":
//                     Square();
//                     break;
//                 case "sqrt":
//                     SquareRoot();
//                     break;
//                 case "M+":
//                     MemoryAdd();
//                     break;
//                 case "M-":
//                     MemorySubtract();
//                     break;
//                 case "MR":
//                     MemoryRecall();
//                     break;
//                 default:
//                     Console.WriteLine("Неизвестная операция");
//                     break;
//             }
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Ошибка: {ex.Message}");
//         }
//     }
//     
//     static double GetNumber()
//     {
//         Console.Write("Введите число: ");
//         return Convert.ToDouble(Console.ReadLine());
//     }
//     
//     static void Add()
//     {
//         double a = GetNumber();
//         double b = GetNumber();
//         Console.WriteLine($"Результат: {a} + {b} = {a + b}");
//     }
//     
//     static void Subtract()
//     {
//         double a = GetNumber();
//         double b = GetNumber();
//         Console.WriteLine($"Результат: {a} - {b} = {a - b}");
//     }
//     
//     static void Multiply()
//     {
//         double a = GetNumber();
//         double b = GetNumber();
//         Console.WriteLine($"Результат: {a} * {b} = {a * b}");
//     }
//     
//     static void Divide()
//     {
//         double a = GetNumber();
//         double b = GetNumber();
//         if (b == 0)
//             throw new Exception("Деление на ноль!");
//         Console.WriteLine($"Результат: {a} / {b} = {a / b}");
//     }
//     
//     static void Percent()
//     {
//         double a = GetNumber();
//         double b = GetNumber();
//         Console.WriteLine($"Результат: {a} % {b} = {a % b}");
//     }
//     
//     static void Reciprocal()
//     {
//         double x = GetNumber();
//         if (x == 0)
//             throw new Exception("Деление на ноль!");
//         Console.WriteLine($"Результат: 1/{x} = {1 / x}");
//     }
//     
//     static void Square()
//     {
//         double x = GetNumber();
//         Console.WriteLine($"Результат: {x}^2 = {x * x}");
//     }
//     
//     static void SquareRoot()
//     {
//         double x = GetNumber();
//         if (x < 0)
//             throw new Exception("Корень из отрицательного числа!");
//         Console.WriteLine($"Результат: sqrt({x}) = {Math.Sqrt(x)}");
//     }
//     
//     static void MemoryAdd()
//     {
//         double x = GetNumber();
//         memory += x;
//         Console.WriteLine($"Добавлено в память: {x}, текущее значение: {memory}");
//     }
//     
//     static void MemorySubtract()
//     {
//         double x = GetNumber();
//         memory -= x;
//         Console.WriteLine($"Вычтено из памяти: {x}, текущее значение: {memory}");
//     }
//     
//     static void MemoryRecall()
//     {
//         Console.WriteLine($"Текущее значение в памяти: {memory}");
//     }
// }