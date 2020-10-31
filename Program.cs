using System;

namespace Задача
{
    class Program
    {
        static void Main(string[] args)
        {
            int R, dat, Res;
            int M35 = 0;
            int M7 = 0;
            int M5 = 0;
            int MAX = 0;
            int N = Convert.ToInt32(Console.ReadLine());
            for (var i = 1; i < N; i++)
            {
                dat = Convert.ToInt32(Console.ReadLine());
                if ((dat % 7 == 0) && (dat > M7) && (dat % 5) > 0)
                {
                    M7 = dat;
                }  else if ((dat % 5 == 0) && (dat > M5) && (dat % 7) > 0)
                {
                    M5 = dat;
                }
                if ((dat % 35 == 0) && (dat > M35))
                {
                    if (MAX<M35)
                    {
                     MAX = M35;
                     M35 = dat;
                    }
                    
                }else if (dat > MAX)
                {
                    MAX = dat;
                }
               R = Convert.ToInt32(Console.ReadLine());
                if ((M7*M5)<(M35*MAX))
                {
                    Res = M35 * MAX;
                } else
                {
                    Res = M7 * M5;
                    Console.WriteLine($"Вычисленное контрольное выражение {Res}");
                }
                if (Res==R)
                {
                    Console.WriteLine("Контроль пройден");
                } else
                {
                    Console.WriteLine("Контроль не пройден");
                }    
            }
        } 
    }
}
