using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserir altura");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserir raio");
            int r = int.Parse(Console.ReadLine());
            float p = 3.1415926f;
            float v = p*(r*r)*a;
            float s = 2*p*r*(r+a);
            Console.WriteLine($"Volume = {v}");
            Console.WriteLine($"Area de superficie = {s}");  
        }
    }
}
