using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int i = 5;
            i++;
            Console.WriteLine(i);
            int b = 4;
            --b;
            Console.WriteLine(b);*/
            int i1 = 3;
            int i2 = 1;
            int i3 = -8;
            int x = 2;
            x %= i2 - 0b1001;
            Console.WriteLine(x);

        }
    }
}
