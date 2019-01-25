using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClightModul2
{
    class Task2
    {
        private static void Main(string[] args)
        {
            /*
             2 Конвертер валют. 5 балла и + 1 возможный доп.балл
               Написать конвертер валют (3 валюты).
               У пользователя есть баланс в каждой из представленных валют. Он может попросить
                сконвертировать часть баланса в одной валюты в другую. Тогда у него с баланса одной валюты
                снимет X и зачислится на баланс другой Y. Курс конвертации должен быть просто прописан в
                программе. 
             */
            float userRub = 0;
            float userUsd = 0;
            float userEur = 0;
            float currentUsdValue = 1;
            float currentRubValue = 66.14f;
            float currentEurValue = 1.13f;


            string RUB = "рублей";
            string USD = "долларов";
            string EUR = "евро";
            string currences = "(RUB/USD/EUR)";
            string greeting = "\nДобро пожаловать в конвертер валют.\n";
            string commands =
                "Команды программы:\n" +
                "Rate - узнать курс обмена.\n" +
                "SetBalance - ввести Ваш текущий баланс.\n" +
                "GetBalance - узнать Ваш текущий баланс.\n" +
                "Change - обменять валюту.\n" +
                "Help - вывести список комманд.\n" +
                "Exit - выход.\n";
            string commandTask = "\nВведите комманду: ";
            string balanceTask = "Введите сколько у Вас есть {0}: ";
            string exchengeFromTask = String.Format("Введите валюту, которую хотите продать {0}: ", currences);
            string exchengeCountTask = "Введите количество валюты, которое хотите продать: ";
            string exchengeToTask = String.Format("Введите валюту которую хотите купить {0}: ", currences);
            string exchengeRezult = "Вы поменяли {0:#.##} {1} на {2:#.##} {3}\n";
            string currentBalance = "Ваш баланс: \n";
            string exchangeRate = "\nТекущий курс валюты:\n";
            exchangeRate = exchangeRate + String.Format("USD = {0:#.##} USD \n", currentUsdValue);
            exchangeRate = exchangeRate + String.Format("RUB = {0:#.##} USD \n", currentRubValue);
            exchangeRate = exchangeRate + String.Format("EUR = {0:#.##} USD \n", currentEurValue);
            string balanceFormat = "{0:#.##} {1}";
            string wrongToCurrency = "\nУ нас нет валюты {0}. "+String.Format("Мы продаём только {0}.\n", currences);
            string wrongFromCurrency = "У Вас нету валюты {0}. "+String.Format("\nУ Вас есть только: {0}\n", currences);
            string wrongCommand = "\nНе изветсная комманда.\n";
            string bye = "\nДо встречи!\n";

            bool isExchengeWorking = true;
            string commandName = "SetBalance";

            Console.WriteLine(greeting);
            Console.WriteLine(commands);
            Console.WriteLine(exchangeRate);

            while (isExchengeWorking)
            {

                Console.ForegroundColor = ConsoleColor.White;
                switch (commandName)
                {
                    case "SetBalance":
                        Console.Write(balanceTask, USD);
                        userUsd = Convert.ToSingle(Console.ReadLine());
                        Console.Write(balanceTask, EUR);
                        userEur = Convert.ToSingle(Console.ReadLine());
                        Console.Write(balanceTask, RUB);
                        userRub = Convert.ToSingle(Console.ReadLine());
                        break;
                    case "GetBalance":
                        Console.WriteLine(currentBalance);
                        Console.WriteLine(balanceFormat, userUsd, USD);
                        Console.WriteLine(balanceFormat, userEur, EUR);
                        Console.WriteLine(balanceFormat, userRub, RUB);
                        break;
                    case "Change":
                        Console.Write(exchengeFromTask);
                        string fromCurrency = Console.ReadLine().ToString();
                        
                        Console.Write(exchengeCountTask);
                        float countCurrency = Convert.ToSingle(Console.ReadLine());


                        Console.Write(exchengeToTask);
                        string toCurrency = Console.ReadLine().ToString();

                        float countCurrencyInUsd = 0;
                        float countRezultCurrency = 0;

                        if (fromCurrency == "RUB")
                        {
                            if (countCurrency > userRub)
                            {
                                countCurrency = userRub;
                            }
                            countCurrencyInUsd = countCurrency / currentRubValue;
                            if (toCurrency == "EUR")
                            {
                                userRub -= countCurrency;
                                countRezultCurrency = countCurrencyInUsd * currentEurValue;
                                userEur += countRezultCurrency;
                            }
                            else if (toCurrency == "USD")
                            {
                                userRub -= countCurrency;
                                countRezultCurrency = countCurrencyInUsd * currentUsdValue;
                                userUsd += countRezultCurrency;
                            }
                            else if (toCurrency == "RUB")
                            {
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(wrongToCurrency);
                                commandName = "Change";
                                continue;
                            }
                        }
                        else if (fromCurrency == "EUR")
                        {
                            if (countCurrency > userEur)
                            {
                                countCurrency = userEur;
                            }
                            countCurrencyInUsd = countCurrency / currentEurValue;
                            if (toCurrency == "USD")
                            {
                                userEur -= countCurrency;
                                countRezultCurrency = countCurrencyInUsd * currentUsdValue;
                                userUsd += countRezultCurrency;
                            }
                            else if (toCurrency == "RUB")
                            {
                                userEur -= countCurrency;
                                countRezultCurrency = countCurrencyInUsd * currentRubValue;
                                userRub += countRezultCurrency;
                            }
                            else if (toCurrency == "EUR")
                            {
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(wrongToCurrency);
                                commandName = "Change";
                                continue;
                            }
                        }
                        else if (fromCurrency == "USD")
                        {
                            if (countCurrency > userUsd)
                            {
                                countCurrency = userUsd;
                            }
                            countCurrencyInUsd = countCurrency / currentUsdValue;
                            if (toCurrency == "EUR")
                            {
                                userUsd -= countCurrency;
                                countRezultCurrency = countCurrencyInUsd * currentEurValue;
                                userEur += countRezultCurrency;
                            }
                            else if (toCurrency == "RUB")
                            {
                                userUsd -= countCurrency;
                                countRezultCurrency = countCurrencyInUsd * currentRubValue;
                                userRub += countRezultCurrency;
                            }
                            else if (toCurrency == "USD")
                            {
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(wrongToCurrency, @toCurrency);
                                commandName = "Change";
                                continue;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(wrongFromCurrency, @fromCurrency);
                            commandName = "Change";
                            continue;
                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(exchengeRezult, countCurrency, fromCurrency, countRezultCurrency, toCurrency);
                        commandName = "GetBalance";
                        continue;
                    case "Help":
                        Console.WriteLine(commands);
                        break;
                    case "Rate":
                        Console.WriteLine(exchangeRate);
                        break;
                    case "Exit":
                        isExchengeWorking = false;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(bye);
                        continue;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(wrongCommand);
                        commandName = "Help";
                        continue;
                }
                Console.Write(commandTask);
                commandName = Console.ReadLine().ToString();

            }

        }
    }
}
