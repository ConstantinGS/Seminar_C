using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите второе число:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1>number2)
            {
                Console.WriteLine("Первое число больше второго");
            }
            else if (number1<number2)
            {
                Console.WriteLine("Второе число больше первого");
            }
            else if (number1==number2)
            {
                Console.WriteLine("Числа равны");
            }
        }



    }

}