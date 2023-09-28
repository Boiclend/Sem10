// Поле шахматной доски определяется парой натуральных чисел, каждое из которых не превосходит восьми: первое число – номер вертикали (при счете слева направо), 
// второе – номер горизонтали (при счете снизу вверх). Требуется выяснить, являются ли поля (k,l) и (m,n) одного цвета.

using System;
                    
public class Program
{
    public static void Main()
    {
        int k = 0, l = 0, m = 0, n = 0;
        
        Console.Write("Введите координату k 1-ой клетки шахматной доски: ");
        k = int.Parse(Console.ReadLine());
        while (k < 1 || k > 8)
        {
            Console.Write("Введённая координата не соответствует размерам игровой доски! Повторите ввод: ");
            k = int.Parse(Console.ReadLine());
        }
        Console.Write("Введите координату l 1-ой клетки шахматной доски: ");
        l = int.Parse(Console.ReadLine());
        while (l < 1 || l > 8)
        {
            Console.Write("Введённая координата не соответствует размерам игровой доски! Повторите ввод: ");
            l = int.Parse(Console.ReadLine());
        }
        Console.Write("Введите координату m 2-ой клетки шахматной доски: ");
        m = int.Parse(Console.ReadLine());
        while (m < 1 || m > 8)
        {
            Console.Write("Введённая координата не соответствует размерам игровой доски! Повторите ввод: ");
            m = int.Parse(Console.ReadLine());
        }
        Console.Write("Введите координату n 2-ой клетки шахматной доски: ");
        n = int.Parse(Console.ReadLine());
        while (n < 1 || n > 8)
        {
            Console.Write("Введённая координата не соответствует размерам игровой доски! Повторите ввод: ");
            n = int.Parse(Console.ReadLine());
        }
        
        if ((k + l + m + n) % 2 == 0)
            Console.WriteLine("Заданные клетки шахматной доски - одинакового цвета!");
        else
            Console.WriteLine("Заданные клетки шахматной доски - разного цвета!");
        
        Console.ReadKey();
    }
}