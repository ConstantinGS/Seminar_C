using System;
namespace ConsoleApp
{
    class Programm{
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            int number3 = Convert.ToInt32(Console.ReadLine());



            if (number1>number2 & number1>number3){
                Console.Write(number1.ToString() + " - максимальное число "); } 

            else if (number2>number1 & number2>number3){
                Console.Write(number2.ToString() + " - максимальное число ");} 

            else if (number3>number1 & number3>number2){
                Console.Write(number3.ToString() + " - максимальное число "); }

            else if (number3==number1 & number3==number2){
                Console.Write(number1.ToString() + " - максимальное число (все числа равны) "); 

            }


        }



    }




}