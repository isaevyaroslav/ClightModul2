using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClightModul2
{
    class Task6
    {
        /*
         6 Загадка. 6 баллов. +1 балл
            У вас есть загадка и вы загадываете ему её. Создайте программу, которая будет считывать с
            консоли ответ:
            - У пользователя есть 3 попытки. После трех ответов программа должна завершиться;
            - Если пользователь вводит "Троллейбус", мы выводим в консоль "Правильно!" и выходим из
            цикла;
            - Если пользователь вводит "Сдаюсь", мы выводим в консоль "Правильный ответ: троллейбус."
            и выходим из цикла;
            - Если пользователь вводит любой другой ответ, мы выводим в консоль "Подумай еще." и
            продолжаем цикл.
            Дополнительные балл если программа будет нормально реагировать на троллейбус,
            ТРОЛЛЕЙБУС и прочие вариации одной и той же строки.
         */
        private static void Main(string[] args)
        {
            string greeting = "Привет. Отгадай загадку с {0} раз: \n";
            string task = "Два конца, два кольца, по середине гвоздик.\n Ваш ответ: ";
            string rightAnswer = "ножницы";
            string rightAnswerTip = "Правильный ответ: ";
            string congratulation = "Поздравляю. Это правильный ответ!";
            string wrongAnswer = "Это не правильный ответ. У Вас осталось {0} попыток. Подумай ещё.";
            string userAnswer = "";
            string exit = "сдаюсь";
            string bye = "Пока.";
            int attemts = 3;

            Console.WriteLine(greeting, attemts);

            while (--attemts >= 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(task);
                userAnswer = Console.ReadLine();
                
                
                if (userAnswer.ToLower() == rightAnswer.ToLower())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(congratulation);
                    break;
                }else if (userAnswer.ToLower() == exit.ToLower())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(rightAnswerTip + rightAnswer);
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (attemts <= 0)
                    {
                        Console.WriteLine("Вы так и не смогли отгадать.\n Правильный ответ: " + rightAnswer);
                    }
                    else
                    {
                        Console.WriteLine(wrongAnswer, attemts);
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(bye);
        }
    }
}
