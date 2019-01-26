using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClightModul2
{
    class task7
    {
        private static void Main(string[] args)
        {
            /*
             7 Бой с боссом. 10 баллов.
                Легенда: Вы – теневой маг и у вас в арсенале есть несколько заклинаний, которые вы можете
                использовать против Босса. Вы должны уничтожить босса и только после этого будет вам
                покой.
                Формально: перед вами босс, у которого есть определенное кол-во жизней и определенный
                ответный урон. у вас есть 4 заклинания для нанесения урона боссу. Программа завершается
                только после смерти босса или смерти пользователя.
                Пример заклинаний
                Рашамон – призывает теневого духа для нанесения атаки (Отнимает 100 хп игроку)
                Хуганзакура (Может быть выполнен только после призыва теневого духа), наносит 100 ед.
                урона
                Межпространственный разлом – позволяет скрыться в разломе и восстановить 250 хп. Урон
                босса по вам не проходит
                Заклинания должны иметь схожий характер и быть достаточно сложными, они должны иметь
                какие-то условия выполнения (пример - Хуганзакура). Босс должен иметь возможность убить
                пользователя.
             */
            string greeting = 
               "Вы – теневой маг и у вас в арсенале есть несколько заклинаний,\n " +
               "которые вы можете использовать против Босса.\n" +
               "Вы должны уничтожить босса и только после этого будет вам покой.";
            string commands = "Ваши заклинания:\n" +
                "Brohesourus (B) - вокруг тебя на некоторое время появляется огненая сфера с молниями, \n" +
                "              которая не даёт противнику нанести удар в полную силу и ранит его.\n" +
                "Vegetinum (V) - вдруг поднимается ветер и вокруг тебя начинает расти длинные листья, оплетая твоё тело\n" +
                "            они залечивают твои раны, но не дают двигаться, что даёт противнику шанс нанести второй удар.\n" +
                "Ugaranulos (U) - из твоей руки вылетает огненный шар, который может пробить броню противника.\n" +
                "             и оставить в нём самовозгарающий кусок угля, который некоторое время отнимает часть его здоровья.\n" +
                "Dandutol (D) - начинается ураган, который в зависимости от вызваных ранее заклинаний наносит некоторый урон противнику,\n" +
                "           но даёт шанс ему нанести ещё один удар.\n" +
                "Help (H) - Из пустоты появляются волшебные чернила и в пустоте пишут все заклинания, которыми Вы владеете.\n" +
                "Exit (E) - Вас окутывают клубы дыма и Вы исчезаете в убежище - изрядно потрёпанным, но непобеждённым.\n";
            string wrongCommand = "Неверная комманда.";
            string enterCommand = "Введите заклинание: ";


            float maxBossHelth = 1000;
            float bossHelth = maxBossHelth;
            bool isBossUgaranuled = false;

            float maxUserHelth = 1000;
            float userHelth = maxUserHelth;
            bool isUserBrohesourus = false;
            bool isUserVegetinum = false;

            float ugaranuledStrength = 0;
            float maxUgaranuledStrength = 100;

            float brohesourusStrength = 0;
            float maxBrohesourusStrength = 100;

            float vegetinumStrength = 0;
            float maxVegetinumStrength = 100;

            float userDamage;
            float bossDamage;

            bool exit = false;
            string commandName = "help";

            Console.WriteLine(greeting);

            while (!exit)
            {
                Console.ForegroundColor = ConsoleColor.White;


                string userStats = "Вы - {0:#} HP\n";
                string bossStats = "Босс - {0:#} HP\n";

                if (isUserVegetinum)
                {
                    userStats = userStats + String.Format("Vegetinum strength - {0:#}\n", vegetinumStrength);
                }
                if (isUserBrohesourus)
                {
                    userStats = userStats + String.Format("Brohesourus strength - {0:#}\n", brohesourusStrength);
                }
                Console.WriteLine(userStats, userHelth);
                if (isBossUgaranuled)
                {
                    bossStats = bossStats + String.Format("Ugaranuled strength - {0:#}\n", ugaranuledStrength);
                }
                Console.WriteLine(bossStats, bossHelth);

                switch (commandName.ToLower())
                {
                    case "e":
                        commandName = "exit";
                        break;
                    case "h":
                        commandName = "help";
                        break;
                    case "b":
                        commandName = "brohesourus";
                        break;
                    case "v":
                        commandName = "vegetinum";
                        break;
                    case "u":
                        commandName = "ugaranulos";
                        break;
                    case "d":
                        commandName = "dandutol";
                        break;
                }

                userDamage = 0;
                bossDamage = 0;

                if (isUserBrohesourus)
                {
                    brohesourusStrength -=20;
                    if(brohesourusStrength < 1)
                    {
                        isUserBrohesourus = false;
                        brohesourusStrength = 0;
                    }
                }
                if (isBossUgaranuled)
                {

                    ugaranuledStrength -= 20;
                    if (brohesourusStrength < 1)
                    {
                        isBossUgaranuled = false;
                        brohesourusStrength = 0;
                    }
                }
                if (isUserVegetinum)
                {

                    vegetinumStrength -= 20;
                    if (vegetinumStrength < 1)
                    {
                        isUserVegetinum = false;
                        vegetinumStrength = 0;
                    }
                }
                
                int bossTotalRelativeDamage = (int)((maxBossHelth - bossHelth) / (maxBossHelth / 100));
                int userTotalRelativeDamage = (int)((maxUserHelth - userHelth) / (maxUserHelth / 100));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                switch (commandName.ToLower())
                {
                    case "exit":
                        exit = true;
                        continue;
                    case "help":
                        Console.WriteLine(commands);
                        break;
                    case "brohesourus":
                        isUserBrohesourus = userHelth>(maxUserHelth/10) || ((int)userHelth)%7==0;
                        if (isUserBrohesourus)
                        {
                            brohesourusStrength = maxBrohesourusStrength;
                            Console.WriteLine("Вокруг Вас появилась огненная сфера с молниями.");
                            if (isUserVegetinum)
                            {
                                Console.WriteLine("Длинные целебные листья Vegetinum загорелись и рассыпались в пепел.");
                                isUserVegetinum = false;
                                vegetinumStrength = 0;
                            }
                            if (((int)brohesourusStrength)% (int)((userTotalRelativeDamage+20)/10) == 0)
                            {
                                Console.WriteLine("Сфера получилась настолько мощной,\n " +
                                    "что одна из молний ударила Босса! (-{0:#} HP)", userTotalRelativeDamage+10);
                                bossDamage += userTotalRelativeDamage+10;
                            }else if((int)brohesourusStrength%(int)(bossTotalRelativeDamage/10) == 0)
                            {
                                Console.WriteLine("В этот момент Босс изловчился и ударил заклинением Frendoler,\n " +
                                    "одна из молний шара ударила Босса! (-{0:#} HP)", (userTotalRelativeDamage + 40) / 2);
                                bossDamage += (userTotalRelativeDamage + 40) / 2;
                                if (bossTotalRelativeDamage < 50)
                                {
                                    Console.WriteLine("Заклинание всё же пробило защиту,\n " +
                                    "нанеся Вам урон (-{0:#} HP)", (userTotalRelativeDamage + 50) / 10);
                                    userDamage += (userTotalRelativeDamage + 50)/10;
                                }
                                else
                                {

                                    Console.WriteLine("Его заклинание отскочило обратно,\n " +
                                    "нанеся Ему урон (-{0:#} HP)", (bossTotalRelativeDamage+50) / 10);
                                    bossDamage += (bossTotalRelativeDamage + 50)/10;
                                }
                            }
                        }
                        else
                        {
                            if(userTotalRelativeDamage > bossTotalRelativeDamage)
                            {
                                Console.WriteLine("В этот момент Босс изподтишка ударил заклинением Hilowlen,\n " +
                                   "Вам не удалось создать сферу и Вы получили урон! (-{0:#} HP)", (userTotalRelativeDamage+20) / 2);
                                userDamage += (userTotalRelativeDamage + 20) / 2;
                            }
                            else
                            {
                                Console.WriteLine("Вам не удалось сформировать сферу. Вы не поняли - что пошло не так.");
                            }
                        }
                         
                        break;
                    case "vegetinum":
                        isUserVegetinum = userHelth < maxUserHelth && !isUserBrohesourus;
                        if (isUserBrohesourus)
                        {
                            Console.WriteLine("Целебные листья поднялись, но столкнувшись со сферой Brohesourus сгорели.");
                        } else if(userHelth >= maxUserHelth)
                        {
                            Console.WriteLine("Целебные листья обыскали Всё твоё тело, но не нашли не единой царапины.");
                        }
                        else
                        {
                            Console.WriteLine("Поднялся ветер, и длинные целебные листья,\n" +
                                "объяв всё Ваше тело, начали исцелять раны. (+{0:#} HP)", userTotalRelativeDamage*2);
                            userHelth += userTotalRelativeDamage*2;
                            vegetinumStrength = maxVegetinumStrength;
                            if(bossTotalRelativeDamage < 70 && bossTotalRelativeDamage%2==0)
                            {
                                Console.WriteLine("Воспользовавшись моментом, Бос прочитал заклятие Numobogen,\n" +
                                    "которое ударило Вас молнией (-{0:#} HP)", (userTotalRelativeDamage+20)/5);
                                userDamage += (userTotalRelativeDamage + 20) / 5;
                            }
                            else
                            {

                                Console.WriteLine("Почувствовав усталось, Бос прочитал заклятие Filodero,\n" +
                                    "которое восполнило его силы (+{0:#} HP)", bossTotalRelativeDamage);
                                bossHelth += bossTotalRelativeDamage;
                            }
                        }
                        break;
                    case "ugaranulos":
                        isBossUgaranuled = bossTotalRelativeDamage > 30 || (bossTotalRelativeDamage + 1) % 4 == 0;
                        if (isBossUgaranuled)
                        {
                            Console.WriteLine("Ваше заклинание пробило всю защиту Босса\n" +
                                " и оставило тлеющий кусок угля внутри него (-{0:#} HP)", bossHelth / 100 * (userHelth / 100));
                            ugaranuledStrength = maxUgaranuledStrength;
                        }
                        else
                        {
                            if(bossTotalRelativeDamage < 50)
                            {
                                Console.WriteLine("Босс успел произнести заклинание защиты и отразил удар.");
                            }
                            else
                            {
                                Console.WriteLine("Босс удачно повернулся и Ваше заклинание лишь ранило его (-{0:#} HP)", bossHelth / 100);
                                bossDamage += bossHelth / 100;
                            }
                        }
                        break;
                    case "dandutol":

                        Console.WriteLine("По небу заметались тучи, чьи-то вещи и даже некоторые дома.\n" +
                            "Вокруг Вас замелькали даже тени, и некоторое время державшийся на ногах Босс был отброшен.");
                        if(bossTotalRelativeDamage > 50)
                        {
                            Console.WriteLine("Он отлетел в дерево и сильно ударился головой (-{0:#} HP)", (bossTotalRelativeDamage+30) / 10);
                            bossDamage += (bossTotalRelativeDamage + 30) / 10;
                        }
                        else
                        {
                            Console.WriteLine("Он покатился по склону и упал в овраг (-{0:#} HP)", (bossTotalRelativeDamage+50) / 5);
                            bossDamage += (bossTotalRelativeDamage + 50) / 5;
                        }

                        if (isUserBrohesourus)
                        {
                            Console.WriteLine("От урагана, сфера Brohesourus увеличилась настолько,\n" +
                                "что сильно ударила Босса (-{0:#} HP)", bossHelth / 20);
                            bossDamage += bossHelth / 20;
                        }
                        if (isUserVegetinum)
                        {
                            Console.WriteLine("Целебные листья Vegetinum, не выдержав урагана, разлетелись как стрелы в разные стороны,\n" +
                                "нанося Боссу раны (-{0:#} HP)", bossHelth / 20);
                            bossDamage += bossHelth / 20;
                        }
                        if (isBossUgaranuled)
                        {
                            Console.WriteLine("Ураганный ветер так сильно раздул тлеющий уголь в ране Босса, что тот взорвался");
                            if(bossTotalRelativeDamage > 50)
                            {
                                Console.WriteLine("нанеся несопоставимый с жизнью урон.\n" +
                                    "Куски его тела разлетелись на несколько метров, орошая это проклятое место и Ваше лицо...");
                                bossHelth = 0;
                            }
                            else
                            {
                                Console.WriteLine(", но предвидя это Босс прочитал заклинание, которое заранее купировало взрыв.\n" +
                                    "На месте тлеющего угля осталась лишь дырка с затянувшейся покругу раной (-{0:#} HP)", bossHelth/10);
                                bossDamage += bossHelth / 10;
                            }
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(wrongCommand);
                        commandName = "help";
                        continue;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                switch (((int)bossTotalRelativeDamage)%7)
                {
                    case 0:
                        Console.WriteLine("Босс использовал быстрое заклинание Manuro\n" +
                            "которое сшибло Вас с ног, ударив о землю (-{0:#} HP)", (userTotalRelativeDamage+50)/10);
                        userDamage += (userTotalRelativeDamage + 30) / 10;
                        break;
                    case 1:
                        Console.WriteLine("Босс использовал заклинание Tapiro,\n" +
                            "откуда ни возьмись, на Вас упал большой камень (-{0:#} HP)", (userTotalRelativeDamage + 50) / 10);
                        userDamage += (userTotalRelativeDamage + 30) / 10;
                        break;
                    case 2:
                        Console.WriteLine("Босс использовал заклинание Barisol,\n" +
                            "Вашу броню пробил огромный огненый шар (-{0:#} HP)", userTotalRelativeDamage + 50);
                        userDamage += userTotalRelativeDamage + 30;
                        break;
                    case 3:
                        Console.WriteLine("Босс использовал заклинание Washon,\n" +
                            "в Вас полетела ледяная стрела (-{0:#} HP)", userTotalRelativeDamage + 30);
                        userDamage += userTotalRelativeDamage + 30;
                        break;
                    case 4:
                        Console.WriteLine("Босс использовал заклинание Zabivel,\n" +
                            "Вы невольно ударили себя кулаком (-{0:#} HP)", (userTotalRelativeDamage+20) / 20);
                        userDamage += (userTotalRelativeDamage + 20) / 5;
                        break;
                    case 5:
                        Console.WriteLine("Босс использовал заклинание Narotive,\n" +
                            "С неба Вас поразила молния (-{0:#} HP)", userTotalRelativeDamage + 50);
                        userDamage += userTotalRelativeDamage + 30;
                        break;
                    case 6:
                        Console.WriteLine("Босс использовал заклинание Kandovid,\n" +
                            "Из его руки вылетело пламя огня, поразив Вас (-{0:#} HP)", userTotalRelativeDamage + 10);
                        userDamage += userTotalRelativeDamage + 10;
                        break;
                    default:
                        Console.WriteLine("Босс использовал заклинание Junovor,\n" +
                            "Из земли выросли стебли бамбука, поцарапав Вас (-{0:#} HP)", (userTotalRelativeDamage + 10)/10);
                        userDamage += (userTotalRelativeDamage + 10) / 2;
                        break;
                }
                if (userDamage < userHelth)
                {
                    userHelth -= userDamage;
                }
                else
                {
                    userHelth = 0;
                }
                if(bossDamage < bossHelth)
                {
                    bossHelth -= bossDamage;
                }
                else
                {
                    bossHelth = 0;
                }
                if(userHelth > 0 && bossHelth > 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(enterCommand);
                    commandName = Console.ReadLine();
                }
                else if(userHelth <= 0)
                {
                    Console.WriteLine("Вы не выдержали ранений и сменили меру пребывания в этом мире. Пока!");
                    break;
                }
                else if(bossHelth <= 0)
                {
                    Console.WriteLine("Босс мёртв! Вы победили! Вы теперь счастливы!");
                    break;
                }
                
            }

        }
    }
}
