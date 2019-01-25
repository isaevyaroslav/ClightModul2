using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClightModul2
{
    class Task3
    {
        private static void Main(string[] args)
        {
            /*
             * 3 Консольное меню. 8 баллов.
                При помощи всего, что вы изучили, создать приложение, которое может обрабатывать
                команды. Т.е. вы создаете меню, ожидаете ввода нужной команды, после чего выполняете
                действие, которое присвоено этой команде.
                Примеры команд (Требуется 4-6 команд, придумать самим)
                SetName – установить имя
                ChangeConsoleColor- изменить цвет консоли
                SetPassword – установить пароль
                WriteName – вывести имя (после ввода пароля)
                Esc – выход из программы
                Программа не должна завершаться после ввода, пользователь сам должен выйти из
                программы при помощи команды.
             */
            string greeting = "Добро пожаловать в программу отображения Вашего имени.\n";
            string commands =
                "Команды программы: \n" +
                " SetName - устанавливает имя; \n" +
                " DisplayName - запрашивает число, и выводит столько раз имя; \n" +
                " SetColor - установка цвета фона консоли и символов; \n" +
                " DisplayBoxWithName - отображение полого квадрата из символов ‘#’ с надписью имени внутри; \n" +
                " Exit - выход из программы;\n";
            string consolColors = "\nЦвета консоли: \n ";
            for (int colorNumber = 0; colorNumber <= 15; colorNumber++)
            {
                consolColors += ((ConsoleColor)colorNumber).ToString() + " - " + colorNumber + ", ";
                if (colorNumber % 5 == 0 && colorNumber != 0)
                {
                    consolColors += "\n ";
                }
            }
            string task = "\nВведите команду: ";
            string wrongCommand = "\nТакой команды нет.";
            string userName = null;
            bool programWorks = true;
            string commandName = "SetName";

            Console.WriteLine(greeting);
            Console.WriteLine(commands);
            while (programWorks)
            {

                switch (commandName)
                {
                    case "SetName":

                        Console.Write("Введите Ваше имя: ");
                        userName = Console.ReadLine();
                        Console.WriteLine("Ваше имя теперь: " + userName);

                        break;
                    case "DisplayName":

                        Console.WriteLine("Сколько раз вывести Ваше имя?");
                        Console.Write("Введите число: ");
                        for (int c = Convert.ToInt32(Console.ReadLine()); c > 0; c--)
                        {
                            Console.WriteLine(userName);
                        }

                        break;
                    case "SetColor":

                        Console.WriteLine(consolColors);

                        Console.Write("Введите число цвета текста консоли (0-15):");
                        Console.ForegroundColor = (ConsoleColor)Convert.ToInt32(Console.ReadLine());

                        Console.Write("Введите число цвета фона консоли (0-15):");
                        Console.BackgroundColor = (ConsoleColor)Convert.ToInt32(Console.ReadLine());
                        Console.Clear();


                        Console.WriteLine(greeting);
                        Console.WriteLine(commands);
                        Console.WriteLine("Ваше имя: " + userName);

                        break;
                    case "DisplayBoxWithName":

                        string cover = "";
                        for (int c = userName.Length + 1; c >= 0; c--)
                        {
                            cover += "#";
                        }
                        Console.WriteLine(cover + "\n#" + userName + "#\n" + cover);

                        break;
                    case "Exit":

                        Console.WriteLine("Досвиданья. Надеюсь, Вам понравилось.");
                        programWorks = false;

                        continue;
                    default:

                        Console.WriteLine(wrongCommand);

                        break;
                }
                Console.Write(task);
                commandName = Console.ReadLine();
            }
        }
    }
}
