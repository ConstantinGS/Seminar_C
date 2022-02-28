using System;
namespace ConsoleApp
{
    class Programm{
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number%2==0)
            {
                Console.WriteLine("Число четное");
            }
            else if (number%2!=0)
            {
                Console.WriteLine("Число нечетное"); 
            }






        }
     }
}