using System;

namespace PI
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x = 1;
            long count = 0L;
            decimal pi = 0;
            DateTime now1 = DateTime.Now;
            int time1 = Convert.ToInt32(now1.ToString("ss"));
            while (1/x >0.00000001M)
            {
                pi += (1 / x);
                x+=2;
                pi -= (1 / x);
                x+=2;
                count += 2;
            }
            pi *= 4;
            DateTime now2 = DateTime.Now;
            int time2 = Convert.ToInt32(now2.ToString("ss"));
            int time = time2 - time1;
            Console.WriteLine("π值"+pi);
            Console.WriteLine("次数为" + count);
            Console.WriteLine("时间为" + time+ "秒");
        }
    }
}
