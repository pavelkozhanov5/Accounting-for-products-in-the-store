using System;

namespace ИCразрабПО
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int N;
            int X;
            int a3 = 0;
            int b3 = 0;
            int a5 = 0;
            int b5 = 0;
            int a0 = 0;
            int b0 = 0;
            int R;
            int m;
            int i;
            N = Convert.ToInt32(Console.ReadLine());
            try
            {
                for (i = 1; i <= N; ++i)
                {
                    X = Convert.ToInt32(Console.ReadLine());
                    if (X % 15 == 0)
                    {

                    }
                    if (X % 3 == 0)
                    {
                        if (X > a3)
                        {
                            b3 = a3;
                            a3 = X;
                        }
                        else if (X > b3)
                        {
                            b3 = X;
                        }
                    }
                    else if (X % 5 == 0)
                    {
                        if (X > a5)
                        {
                            b5 = a5;
                            a5 = X;
                        }
                        else if (X > b5)
                        {
                            b5 = X;
                        }
                    }
                    else
                    {
                        if (X > a0)
                        {
                            b0 = a0;
                            a0 = X;
                        }
                        else if (X > b0)
                        {
                            b0 = X;
                        }
                    }
                    R = Convert.ToInt32(Console.ReadLine());
                    m = a0 * a3;
                    if (a0 * a5 > m)
                    {
                        m = a0 * a5;
                    }
                    if (a0 * b0 > m)
                    {
                        m = a0 * b0;
                    }
                    if (a3 * b3 > m)
                    {
                        m = a3 * b3;
                    }
                    if (a5 * b5 > m)
                    {
                        m = a5 * b5;
                    }
                    Console.WriteLine($"Получено чисел: {N}");
                    Console.WriteLine($"Принятое контрольное значение: {R}");
                    if (m > 0)
                    {
                        Console.WriteLine($"Вычислительное контрольное значение: {m}");
                    }
                    if ((R > 0) && (R == m))
                    {
                        Console.WriteLine("Контроль пройден");
                    }
                    else
                    {
                        Console.WriteLine("Контроль не пройден");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено некорректное значение ");
            }
        
        }
    }
}
