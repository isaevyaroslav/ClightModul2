using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClightMoul2
{
    class Task1
    {
        private static void Main(string[] args)
        {
            //Легенда: Вы оказались перед дверью, которая открывается только при вашем 18летии.После
            //открытия двери вы видите сообщение.
            //Формально: Есть bool переменная IsDoorOpen, она равна true только если пользователю есть
            //18 Возвраст пользователя программа также запрашивает сама.
            byte minUserAge = 18;
            byte userAge = 0;
            bool IsDoorOpen = false;

            string greeting = "Здравствуйте, дверь закрыта.\n";
            string task = "Чтобы открыть дверь укажите Ваш возраст: ";
            string lowAge = "Вы слишком молоды, чтобы увидеть то что за этой дверью!\n";
            string rightAge = "\nДобро пожаловать!\n";
            string adultMeseage =
                "Вы вошли в дверь и увидели стол на котором лежит записка: \n" +
                "\"Теперь тебе достаточно лет чтобы знать, что делить на ноль можно.\n" +
                "Результатом деления на ноль будет infinity, т.е. бесконечность.\n" +
                "Хорошего дня!\"\n";

            Console.WriteLine(greeting);
            while (!IsDoorOpen)
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(task);
                userAge = Convert.ToByte(Console.ReadLine());
                IsDoorOpen = userAge >= minUserAge;

                if (!IsDoorOpen)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(lowAge);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(rightAge);
                    Console.WriteLine(adultMeseage);
                }
            }
        }

    }
}
