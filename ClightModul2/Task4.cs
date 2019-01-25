using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClightModul2
{
    class Task4
    {
        /*
         
        4 Последовательность. 2 балла + 1 возможный доп.
            Нужно написать программу (использую циклы, пояснить выбор вашего цикла), чтобы она
            выводила следующую последовательность 7 14 21 28 35 42 49 56 63 70 77 84 91 98
         
         */
        private static void Main(string[] args)
        {
            for (int i = 7; i <= 98; i += 7)
            {
                Console.WriteLine(i);
            }
        }
        // for, потому что он уже имеет счётчик-переменную в себе и позволяет её увеличивать на любое количество.
    }
}
