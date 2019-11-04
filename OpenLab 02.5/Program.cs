using System;

namespace OpenLab_02._5
{
    class Program
    {
        public static bool delitelne(int x)
        {
            if (x % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Zadaj číslo, ktoré chceš aby ti napísalo či je delitelné 5 ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(delitelne(x));
        }
    }
}
