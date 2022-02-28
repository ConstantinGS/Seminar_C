using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i<=number)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}






