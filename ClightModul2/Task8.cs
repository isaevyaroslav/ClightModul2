using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClightModul2
{
    class Task8
    {
        private static void Main(string[] args)
        {
            /*
             8 Программа под паролем. 3 балла + 1 балл
                Создайте переменную типа string в которую пользователь вводит пароль, далее проверьте
                пароль на правильность, и если пароль неверный, то попросите его ввести пароль ещё раз.
                Если пароль подошёл, выведите секретное сообщение.
                Дополнительный балл:
                Сделайте счётчик неверных вводов пароля, и при достижении числа 5, завершите программу.
             */
            int attemptsNumber = 5;
            int attemptsCounter = 0;
            string password = "ThroneMaster#1";
            string greeting = "Добро пожаловать. Вы пытаетесь узнать секретное сообщение.";
            string task = "Введите правильный пароль для того чтобы узнать секретное сообщение (у Вас осталось {0} попыток): ";
            string wrongPassword = "Вы ввели неверный пароль.";
            string rightPassword = "Вы ввели верный пароль. Добро пожаловать!";
            string messageContainer = "Секретное сообщение: \"{0}\"";
            string secretMessage = "Ключ от сейфа в нижнем ящике комода.";
            string attemptsOver = "У Вас не осталось больше попыток. Узнайте пароль у его владельца и возвращайтесь. Досвиданья.";
            string passwordAttempt;
            bool passwordCorrect = false;

            Console.WriteLine(greeting);
            while (attemptsCounter++ <= attemptsNumber && passwordCorrect == false)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(String.Format(task, attemptsNumber - attemptsCounter + 1));
                passwordAttempt = Console.ReadLine();
                passwordCorrect = passwordAttempt == password;
                if (passwordCorrect)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(rightPassword);
                    Console.WriteLine(String.Format(messageContainer, secretMessage));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (attemptsCounter == attemptsNumber)
                    {
                        Console.WriteLine(attemptsOver);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(wrongPassword);
                    }
                }

            }
        }
    }
}
