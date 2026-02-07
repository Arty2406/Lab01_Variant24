
using System;

class Lab01_Variant24_QuadraticEquation
{
    public double D { get; set; }

    static void Main(string[] args) //главное меню
    {
        string num = "";
        do
        {
            try
            {
                Console.WriteLine("ОПЕРАЦИИ:\n" +
                "1. Расчёт дискриминанта.\n" +
                "2. Определение количества корней.\n" +
                "3. Сумма и произведение корней по теореме Виета.\n" +
                "4. Выход из программы.\n" +
                "Введите номер операции (1 .. 12): ");

                num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        double D = discriminant();
                        break;
                    case "2":
                        definition(D);
                        break;
                    case "3":
                        double a, b, c = theorem(a, b, c);
                        break;
                    case "4":
                        Console.WriteLine("Выход из программы.");
                        break;
                    default:
                        Console.WriteLine("Неверный ввод данных.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите нужный формат числа!\n" +
                " ");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Произошло переполнение!\n" +
                " ");
            }
        } while (num != "4");
    }
    static double discriminant()
    {
        // Ввод коэффициентов
        Console.WriteLine("Введите коэффициенты квадратного уравнения a(x^2) + bx + c = 0:");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        // Задача 1: вычисление дискриминанта (с учётом двух знаков после запятой)
        double D = b * b - 4 * a * c;
        Console.WriteLine("1. Дискриминант:\n" +
                          $"D = {D:F2}");

        return D;
    }
    static void definition(double D)
    {
        // Задача 2: определение количества корней
        Console.WriteLine($"2. Определение дискриминанта:\n" +
                          $"При D > 0: два корня (ваш D = {D:F2})\n" +
                          $"При D = 0: один корень (ваш D = {D:F2})\n" +
                          $"При D < 0: нет корней (ваш D = {D:F2})");
    }
    static void theorem(double b, double a, double c)
    {
        // Задача 3: сумма и произведение корней по теореме Виета (с учётом двух знаков после запятой)
        double sum = -b / a;      // x1 + x2 = -b/a
        double product = c / a;   // x1 × x2 = c/a

        Console.WriteLine($"3. По теореме Виета:\n" +
                          $"   Сумма корней: x1 + x2 = {sum:F2}\n" +
                          $"   Произведение корней: x1 * x2 = {product:F2}");
    }

}
 
