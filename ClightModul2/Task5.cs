using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClightModul2
{
    class Task5
    {
        /*
         5 Вывод имени. 4 балла.
            Вывести имя в прямоугольник из символа, которые введет сам пользователь.
            Вы запрашиваете имя, после запрашиваете символ, а после отрисовываете в консоль его имя в
            прямоугольнике из его символов.
         */
         
        private static void Main(string[] args)
        {
            string greeting = "Добро пожаловать в декоратор имени!\n";
            string nameTask = " Введите Ваше имя:";
            string charTask = " Введите знак для декорации:";
            string userName = "";
            char niceChar = ' ';
            string cover = "";

            Console.WriteLine(greeting);
            Console.Write(nameTask);
            userName = Console.ReadLine();
            Console.Write(charTask);
            niceChar = Console.ReadLine()[0];

            for (int c = userName.Length + 1; c >= 0; c--)
            {
                cover += niceChar;
            }
            Console.WriteLine(cover + "\n"+ niceChar + userName + niceChar + "\n" + cover);
        }
        
    }
}
