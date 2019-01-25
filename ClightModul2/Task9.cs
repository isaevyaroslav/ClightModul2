using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClightModul2
{
    class Task9
    {
        private static void Main(string[] args)
        {
            /*
             9 Диалог. 4 балла
                Выразите в программе следующее дерево диалога.
             */
            string userName = "";
            uint userAge = 0;
            Console.WriteLine("Привет, как тебя зовут?");
            Console.Write("Ответ: ");
            userName = Console.ReadLine();
            Console.WriteLine("Привет"+userName+", сколько тебе лет?");
            Console.Write("Ответ: ");
            userAge = Convert.ToUInt32(Console.ReadLine());
            if (userAge > 18)
            {

                Console.WriteLine("Замечательно, ты ходишь в школу?");
                Console.Write("Ответ: ");
                if(Console.ReadLine().ToLower() == "да")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Обманщик, тебе нет 18!");
                }
                else
                {
                    Console.WriteLine("Сентябрь горииит...\n" +
                        "1) Убийца плачет\n" +
                        "2) Птица парит\n" +
                        "3) Что это вообще такое?\n");
                    Console.Write("Ответ: ");
                    if(Convert.ToUInt32(Console.ReadLine()) == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Блеск, ты прошёл мой тест!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Обманщик!");
                    }
                }
            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Извини, но тебе закрыт доступ к программе!");
            }
        }
    }
}
