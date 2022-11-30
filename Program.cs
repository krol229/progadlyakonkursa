using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.Xml.Linq;

namespace uchenierussianlang
{
    class CObject
    {
        public string[] obj = { "камень", "ножницы", "бумага" };
        public string user = null;
    }
    class CInterface
    {
        public void draw()
        {
            Console.SetCursorPosition(0, 0);
            Console.Clear();
            for (int i = 0; i <= 24; i++)
            {
                Console.WriteLine(face[i]);
            }
        }
        public string Title;
        public string Query;
        public string[] face;
        public CInterface()
        {
            Title = "Русский язык";
            Query = "цйфыкафыв";
            face = new string[27];
            face[0] = "    -------------------------------------------------------";
            face[1] = "    |               Учебник Русского языка                |";
            face[2] = "--------------------------------------------------------------";
            face[3] = "|                            Что хотите повторить/выучить?   |";
            face[4] = "| 1. Существительные                                         |";
            face[5] = "|                                                            |";
            face[6] = "| 2. Глаголы                                                 |";
            face[7] = "|                                                            |";
            face[8] = "| 3. Прилагательные                                          |";
            face[9] = "|                                                            |";
            face[10] = "| 4. Числительные                                            |";
            face[11] = "|                                                            |";
            face[12] = "| 5. Наречие                                                 |";
            face[13] = "|                                                            |";
            face[14] = "| 6. Частицы                                                 |";
            face[15] = "|                                                            |";
            face[16] = "| 7. Причастия                                               |";
            face[17] = "|                                                            |";
            face[18] = "| 8. Деепричастия                                            |";
            face[19] = "|                                                            |";
            face[20] = "| 9. Местоимения                                             |";
            face[21] = "|                                                            |";
            face[22] = "--------------------------------------------------------------";
            face[23] = "|                                                            |";
           // face[24] = "|                                                            |";
        }
    }
    internal class Program
    {
        static void nazadsusch()
        {
            int padezhinummenu = Convert.ToInt32(Console.ReadLine());
            if (padezhinummenu == 9);
        }
        static void nazadgglag()
        {
            int glagnummenu = Convert.ToInt32(Console.ReadLine());
            if (glagnummenu == 9);
        }
        static void nazadpril()
        {
            int prilnummenu = Convert.ToInt32(Console.ReadLine());
            if (prilnummenu == 9);
        }
        static void nazadchisl()
        {
            int chislnummenu = Convert.ToInt32(Console.ReadLine());
            if (chislnummenu == 9);
        }
        static void nazadnar()
        {
            int narnummenu = Convert.ToInt32(Console.ReadLine());
            if (narnummenu == 9);
        }
        static void nazadchast()
        {
            int chastnummenu = Convert.ToInt32(Console.ReadLine());
            if (chastnummenu == 9);
        }
        static void nazadprich()
        {
            int prichnummenu = Convert.ToInt32(Console.ReadLine());
            if (prichnummenu == 9);
        }
        static void nazaddeeprich()
        {
            int deeprichnummenu = Convert.ToInt32(Console.ReadLine());
            if (deeprichnummenu == 9);
        }
        static void Main(string[] args)
        {
            Console.WindowHeight = 63;
            Console.WindowWidth = 240;
            int intro = 1;
            Console.WriteLine("Пропустить вступление?");
            string otvet = Console.ReadLine();
            //тут вступление
            if (otvet == "Да" || otvet == "дА" || otvet == "ДА" || otvet == "да")
            {
                Console.Clear();
                intro++;
                if (intro == 2) {}
            }
            else if (otvet == "Нет" || otvet == "нЕт" || otvet == "неТ" || otvet == "НЕт" || otvet == "нЕТ" || otvet == "НЕТ" || otvet == "нет")
            {
                Console.Clear();
                intro--;
                if (intro == 0)
                {
                    foreach (char introkakraz in "Здравствуй, эта программа придумана мною, чтоб повторять\n и/или изучать русский язык, тут вы будете познавать ")
                    {
                        Console.Write(introkakraz);
                        Thread.Sleep(50);
                    }
                    foreach (char introkakrazabz in "\n все основы русского языка(по моему мнению)")
                    {
                        Console.Write(introkakrazabz);
                        Thread.Sleep(50);
                    }
                    foreach (char introkakrazabzescheodin in "\n А ну да, можете нажать на Alt+Enter, что бы войти в полноэкранный режим")
                    {
                        Console.Write(introkakrazabzescheodin);
                        Thread.Sleep(50);
                    }
                    foreach (char introkakrazabzescheodinuk in "\n и если нажмете еще раз на эту комбинацию, то можно выйти из полноэкранного режима")
                    {
                        Console.Write(introkakrazabzescheodinuk);
                        Thread.Sleep(50);
                    }
                }
                Thread.Sleep(4000);
                Console.Clear();
            }
            CObject game = new CObject();
            CInterface iFace = new CInterface();
            Console.Title = iFace.Title;
            Console.ForegroundColor = ConsoleColor.White;
            ConsoleKeyInfo keyCode = new ConsoleKeyInfo();
            while (keyCode.Key != ConsoleKey.Escape) 
               {
                   iFace.draw();
            int nummenu = Convert.ToInt32(Console.ReadLine());
            if (nummenu == 1)
            {
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    Console.WriteLine("|                              Имя существительное                                             |");
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    Console.WriteLine("|  Существительное — самостоятельная часть речи,                                               |");
                    Console.WriteLine("|        обозначающая предмет, лицо или явление и отвечающая на вопросы «кто?» или «что?»      |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 1. Падежи                                                      Одушевленные - «кто?»         |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 2. Число                                                                                     |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 3. Род                                                                                       |");
                    Console.WriteLine("|                                                                Неодушевленные -  «что?»      |");
                    Console.WriteLine("| 4. Собственное и нарицательное                                                               |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 5. Мягкий знак после шипящих                                                                 |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 9. В главное меню                                                                            |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    int suschestvitelnummenu = Convert.ToInt32(Console.ReadLine());
                    if (suschestvitelnummenu == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                 Падежи                                                       |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|   Существительные могут склонятся по падежам, а вот их список:                               |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|   Именительный                                                                               |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|   Существительные в именительном падеже отвечают на вопросы: Кто? Что?                       |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|            Культурный (кто?) гость                Постряпали (что?) пирог                    |");
                        Console.WriteLine("|   Родительный                                                                                |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|            Существительные в именительном падеже отвечают на вопросы: Кого? Чего?            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                      Нет (чего?) ручки                   Нет (кого?) кота                    |");
                        Console.WriteLine("|   Дательный                                                                                  |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|           Существительные в именительном падеже отвечают на вопросы: Кому? Чему?             |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|             Дать ручку (кому?) ученику          идти (к чему?) к цели.                       |");
                        Console.WriteLine("|   Винительный                                                                                |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|              Существительные в именительном падеже отвечают на вопросы: Кого? Что?           |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                Вижу (кого?) кота                Вижу (что?) арбуз                            |");
                        Console.WriteLine("|   Творительный                                                                               |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                Существительные в именительном падеже отвечают на вопросы: Кем? Чем?          |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                Гулять (с кем?) с друзьями        Рисовать (чем?) красками                    |");
                        Console.WriteLine("|   Предложный                                                                                 |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                Существительные в именительном падеже отвечают на вопросы: О ком? О чем?      |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|         Говорить (о ком?) о родителях               Думать (о чем?) о предмете               |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|    9. В главное меню                                                                         |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadsusch();
                    }
                    else if (suschestvitelnummenu == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                 Число                                                        |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|     В единственном числе, как правило, существительные имеют окончания:                      |");
                        Console.WriteLine("|            нулевое, -о, -а, -я, -е; во множественном числе окончания –ы, -и-, -а, -ья.       |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|       подушка — подушки                                крыло — крылья                        |");
                        Console.WriteLine("|       груша — груши                                    дочь — дочери                         |");
                        Console.WriteLine("|       сестра — сестры                                  небо — небеса                         |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|       В редких случаях формы множественного числа можно образовать заменой корня:            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                      человек — люди                                                          |");
                        Console.WriteLine("|                              ребенок — дети                        9. В главное меню         |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadsusch();
                    }
                    else if (suschestvitelnummenu == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                 Род                                                          |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|        Род — постоянный признак имени существительного                                       |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|     мужской род                                      средний род                             |");
                        Console.WriteLine("|  огонь, учебник, дедушка, директор                  солнце, племя, лото.                     |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|    женский род                                                                               |");
                        Console.WriteLine("|  планета, мать, ночь, аллея                                                                  |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|   9. В главное меню                                                                          |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadsusch();
                    }
                    else if (suschestvitelnummenu == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                            Собственное и нарицательное                                       |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|  Собственные существительные обозначают — имена, фамилии, отчества, клички животных,         |");
                        Console.WriteLine("|    географические названия, и т.д. (Москва, Волга, Мария, Каштанка, Алексей                  |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  Нарицательные существительные  — название предметов и явлений ученик, учебник, страна, лес. |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|    9. В главное меню                                                                         |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadsusch();
                    }
                    else if (suschestvitelnummenu == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                            Мягкий знак после шипящих                                         |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|  Пишется — в женском роде (мышь, рожь, печь, ложь, мощь)                                     |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  Не пишется — в мужском роде  (гараж, камыш, товарищ, борщ)                                  |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|    9. В главное меню                                                                         |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadsusch();
                    }
                    else if (suschestvitelnummenu == 9) nazadsusch();
                    else
                    {
                        Console.WriteLine("Такого меню нет(");
                        Thread.Sleep(1000);
                    }
                }
            else if (nummenu == 2)
            {
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    Console.WriteLine("|                              Глагол                                                          |");
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    Console.WriteLine("|  Глагол — самостоятельная часть речи, которая обозначает                                     |");
                    Console.WriteLine("|     состояние или действие предмета и отвечает на вопросы что делать? что сделать?           |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 1. Неопределённая форма глагола                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 2. Вид глагола                                                                               |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 3. Спряжение глаголов                                                                        |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 4. Время глагола                                                                             |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 5. Правописание НЕ с глаголами                                                               |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 6. Правописание -ТСЯ и -ТЬСЯ                                                                 |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 7. Наклонение глагола                                                                        |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 9. В главное меню                                                                            |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    int glagolnummenu = Convert.ToInt32(Console.ReadLine());
                    if (glagolnummenu == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                            Неопределённая форма глагола                                      |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|   Неопределённая форма – это начальная форма глагола.                                        |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  Глаголы в неопределённой форме отвечают на вопросы что делать?                              |");
                        Console.WriteLine("|                          что сделать?, оканчиваются на -ТИ, -ТЬ или -ЧЬ                      |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|   Не имеют признаков времени, числа, лица и рода (идти, печь, стричь).                       |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                        9. В главное меню                     |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadgglag();
                    }
                    else if (glagolnummenu == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                            Вид глагола                                                       |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|      совершенный вид — глаголы отвечают на вопрос что сделать?                               |");
                        Console.WriteLine("|       и обозначают уже совершённое действие или действие в начальной стадии исполнения       |");
                        Console.WriteLine("|                                          (решить, прочесть, спеть, запеть)                   |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  несовершенный вид — глаголы отвечают на вопрос что делать?                                  |");
                        Console.WriteLine("|                                            (решать, читать, петь, запевать)                  |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                        9. В главное меню                     |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadgglag();
                    }
                    else if (glagolnummenu == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                            Спряжение глаголов                                                |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|   I спряжение —  глаголы в неопределённой форме оканчиваются на:                             |");
                        Console.WriteLine("|   -ЕТЬ, -АТЬ, -ОТЬ, -УТЬ, -ЯТЬ, -ЫТЬ;                                                        |");
                        Console.WriteLine("|   в 3-м лице мн. ч. оканчиваются на -УТ, -ЮТ (петь, прятать, колоть, тянуть, веять, мыть)    |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|   II спряжение —  глаголы в неопределённой форме оканчиваются на -ИТЬ;                       |");
                        Console.WriteLine("|    в 3-м лице мн. ч. оканчиваются на -АТ, -ЯТ (возить, пилить, тратить)                      |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  ИСКЛЮЧЕНИЯ!                                                                                 |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  Эти глаголы относятся к I спряжению: брить, стелить, зиждиться, зыбить                      |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  Эти глаголы относятся ко II спряжению:                                                      |");
                        Console.WriteLine("|  гнать, дышать, держать, зависеть, слышать,                                                  |");
                        Console.WriteLine("|  видеть, ненавидеть, терпеть, вертеть, обидеть, смотреть                                     |");
                        Console.WriteLine("|                                                        9. В главное меню                     |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadgglag();
                    }
                    else if (glagolnummenu == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                            Время глагола                                                     |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|   Глаголы изменяются по временам: Настоящее, прошедшее и будущее                             |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|   Настоящее время относится к действиям, которые происходят в момент речи:                   |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| Отвечают на вопросы: что делаю? что делаешь? что делает? что делаем? что делаете?            |");
                        Console.WriteLine("|   Примеры: Я иду, Мы идём, Ты идешь, Они идут.                                               |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|  Прошедшее время относится к действиям, которые к моменту речи уже завершились.              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|   Отвечают на вопросы: что делал? что делала? что делало? что делали?                        |");
                        Console.WriteLine("|   Примеры: Я шёл, Он шёл, Мы шли, Они шли                                                    |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|   Будущее время относится к действиям, которые произойдут в будущем.                         |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| Отвечают на вопросы: что сделаю? что сделаешь? что сделает?                                  |");
                        Console.WriteLine("|                              что сделаем? что сделаете? что сделают?                         |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  Примеры: Я пойду, Мы пойдём, Он пойдёт, Они пойдут                                          |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                        9. В главное меню                     |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadgglag();

                    }
                    else if (glagolnummenu == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                           Правописание НЕ с глаголами                                        |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|   НЕ с глаголами всегда пишется раздельно (Не спать! Он не боялся идти в лес.)               |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  Глаголы, которые без НЕ не употребляются:                                                   |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|         негодовать, недоумевать, ненавидеть, несдобровать, нездоровиться.                    |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                        9. В главное меню                     |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadgglag();
                    }
                    else if (glagolnummenu == 6)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|            Правописание -ТСЯ и -ТЬСЯ                                                         |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|   Чтобы узнать, пишется у глагола -ТСЯ или -ТЬСЯ, нужно поставить вопрос                     |");
                        Console.WriteLine("|  При вопросах что делать?/что сделать? пишется -ТЬСЯ,                                        |");
                        Console.WriteLine("|  при вопросах что делает?/что сделает? пишется -ТСЯ.                                         |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|   Что делать? купаться, смеяться, возиться, лениться, учиться.                               |");
                        Console.WriteLine("|   Что делает? купается, смеётся, возится, ленится, учится.                                   |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                        9. В главное меню                     |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadgglag();
                    }
                    else if (glagolnummenu == 7)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                            Наклонение глагола                                                |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| Изъявительное наклонение — обозначает действие,                                              |");
                        Console.WriteLine("|                    которое происходило, происходит или произойдёт (спал, сплю, буду спать)   |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| Cослагательное (условное) наклонение — обозначает действие желаемое или возможное,           |");
                        Console.WriteLine("|        образуется с помощью формы прошедшего времени глагола                                 |");
                        Console.WriteLine("|           и частицы БЫ (я написал бы, вы пришли бы)                                          |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| Повелительное — обозначает побуждение к действию,                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                           приказ, просьбу (принесите, стойте, встань)                        |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                        9. В главное меню                     |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadgglag();
                    }
                    else if (glagolnummenu == 9) nazadsusch();
                }
            else if (nummenu == 3)
            {
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    Console.WriteLine("|                              Прилагательные                                                  |");
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    Console.WriteLine("|      Имя прилагательное – это самостоятельная часть речи,                                    |");
                    Console.WriteLine("|          которая обозначает признак предмета и отвечает на вопросы какой? чей?               |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 1. Разряды имён прилагательных                                                               |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 2. Непостоянные признаки                                                                     |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 3. Полные и краткие прилагательные                                                           |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 4. Окончания кратких прилагательных                                                          |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 5. Написание -н- и -нн- в кратких прилагательных                                             |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 6. Правописание НЕ в прилагательных                                                          |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 9. В главное меню                                                                            |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    int prilnummenu = Convert.ToInt32(Console.ReadLine());
                    if (prilnummenu == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                             Разряды имён прилагательных                                      |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|  Качественные — обозначают признак предмета,                                                 |");
                        Console.WriteLine("|     который может присутствовать в этом предмете в большей или меньшей степени;              |");
                        Console.WriteLine("|    имеют полную и краткую форму, сравнительную и превосходную степень                        |");
                        Console.WriteLine("|                         (тёмный, сильный, новый, крепкий, грязный, мягкий, низкий, молодой)  |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| Относительные — обозначают признак предмета,                                                 |");
                        Console.WriteLine("|  который не может быть в нём в большей или меньшей степени (деревянный, шерстяной, солнечный)|");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|   Притяжательные — обозначают признак по принадлежности его                                  |");
                        Console.WriteLine("|                      кому-либо или чему-либо (заячий выводок, волчье логово, Егорушкин отец) |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 9. В главное меню                                                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadpril();
                    }
                    else if (prilnummenu == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                              Непостоянные признаки                                           |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|    Число                                                                                     |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|    Падеж                                                                                     |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|    Род                                                                                       |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|    Форма                                                                                     |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|    Степень сравнения                                                                         |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 9. В главное меню                                                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadpril();
                    }
                    else if (prilnummenu == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                          Полные и краткие прилагательные                                     |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| Краткое прилагательное отвечает на вопрос каков?                                             |");
                        Console.WriteLine("|      и согласуется с существительным или местоимением,                                       |");
                        Console.WriteLine("|        к которому оно относится, в роде и числе (по падежам не изменяется)                   |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|   В предложении краткие прилагательные обычно выступают в роли сказуемого: Он так умён!      |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| В роли определений краткие прилагательные выступают в некоторых фразеологических оборотах:   |");
                        Console.WriteLine("|        на босу ногу, по белу свету, средь бела дня, добры молодцы, красна девица             |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 9. В главное меню                                                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadpril();
                    }
                    else if (prilnummenu == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                          Окончания кратких прилагательных                                    |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| Единственное число                                                                           |");
                        Console.WriteLine("|   мужской род — нулевое окончание (крепкий — крепок, новый — нов, тощий — тощ)               |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|   женский род — окончание  -А (крепкая — крепка, новая — нова, тощая — тоща )                |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|   средний род — окончание -О, -Е (крепкое — крепко, новое — ново, тощее — тоще)              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  Множественное число                                                                         |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| Окончание -Ы, -И — (крепкие- крепки, новые — новы, тощие — тощи)                             |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 9. В главное меню                                                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadpril();
                    }
                    else if (prilnummenu == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                   Написание -н- и -нн- в кратких прилагательных                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| в прилагательных с суффиксами -ЕНН-, -ОНН-  (дискуссионный, искусственный)                   |");
                        Console.WriteLine("|                                             Исключение: ветреный                             |");
                        Console.WriteLine("| в прилагательных, образованных от слов с основой на -Н- (длинный, истинный)                  |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| в прилагательных, которые не образованы от других частей речи (синий, зелёный, юный)         |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  в прилагательных с суффиксами -АН, -ЯН, -ИН (воробьиный, вощаной, глиняный, голубиный)      |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 9. В главное меню                                                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadpril();
                    }
                    else if (prilnummenu == 6)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                             Правописание НЕ в прилагательных                                 |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| если прилагательное с НЕ можно заменить синонимом без НЕ                                     |");
                        Console.WriteLine("|              (небольшой = маленький; неженатый = холостой, ненастоящий = ложный)             |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| при наличии слов в высшей степени,                                                           |");
                        Console.WriteLine("|  весьма, вполне, крайне, очень, почти, отчасти, совершенно, совсем, чрезвычайно              |");
                        Console.WriteLine("|                    (очень неглупый, почти незаметный)                                        |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| Раздельно                                                                                    |");
                        Console.WriteLine("|         При наличии противопоставления с союзом А (не смелый, а трусливый)                   |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  Если перед НЕ стоят слова отнюдь не, далеко не, вовсе не (далеко не весёлый фильм)          |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  при логически подчёркнутом отрицании (семья не богатая)                                     |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 9. В главное меню                                                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadpril();
                    }
                    nazadpril();
                }
            else if (nummenu == 4)
            {
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    Console.WriteLine("|                              Числительные                                                    |");
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    Console.WriteLine("| Имя числительное – это самостоятельная часть речи,                                           |");
                    Console.WriteLine("|       которая обозначает количество и порядок предметов при счёте                            |");
                    Console.WriteLine("|               (пять, двадцать семь, шестьсот, девятьсот тридцать седьмой)                    |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|  НЕ с числительными всегда пишется РАЗДЕЛЬНО: не три, не девятый                             |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|  Ь пишется на конце — пять, шесть, семь, восемь, девять, десять,                             |");
                    Console.WriteLine("|    одиннадцать, двенадцать, тринадцать, четырнадцать, пятнадцать,                            |");
                    Console.WriteLine("|                  шестнадцать, семнадцать, восемнадцать, девятнадцать, двадцать, тридцать.    |");
                    Console.WriteLine("| Ь пишется в середине в И. п. и В. п. —                                                       |");
                    Console.WriteLine("|  пятьдесят, шестьдесят, семьдесят, восемьдесят,                                              |");
                    Console.WriteLine("|   пятьсот, шестьсот, семьсот, восемьсот, девятьсот                                           |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| Непостоянные морфологические признаки имени числительного:                                   |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|  1. Падеж                                                                                    |");
                    Console.WriteLine("|  2. Число                                                                                    |");
                    Console.WriteLine("|  3. Род                                                                                      |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 9. В главное меню                                                                            |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    int chislnummenu = Convert.ToInt32(Console.ReadLine());
                    if (chislnummenu == 9);
                }
            else if (nummenu == 5)
            {
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    Console.WriteLine("|                              Наречие                                                         |");
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    Console.WriteLine("|                     Наречие – это самостоятельная часть речи,                                |");
                    Console.WriteLine("|               которая обозначает признак действия (свернуть вправо),                         |");
                    Console.WriteLine("|       признак другого признака (очень холодный), признак предмета (прогулка пешком)          |");
                    Console.WriteLine("|        и отвечает на вопросы: КАК? КУДА? КОГДА? ПОЧЕМУ? ЗАЧЕМ? В КАКОЙ СТЕПЕНИ?              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|  1. Разряды наречий                                                                          |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|  2. Степени сравнения наречий                                                                |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|  3. Правописание НЕ в наречиях                                                               |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|  4. Правописание суффиксов наречий                                                           |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 9. В главное меню                                                                            |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    nazadnar();
                    int narnummenu = Convert.ToInt32(Console.ReadLine());
                    if (narnummenu == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                              Разряды наречий                                                 |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|  ОПРЕДЕЛИТЕЛЬНЫЕ                                                                             |");
                        Console.WriteLine("| Качественные (как? с каким качеством?) —                                                     |");
                        Console.WriteLine("|    быстро, грустно, весело, зверски, правильно, странно, страшно, холодно, чудовищно         |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| Меры и степени (сколько? в какой степени?) —                                                 |");
                        Console.WriteLine("|    абсолютно, вдвоём, вдвойне, весьма, втроём, втройне,                                      |");
                        Console.WriteLine("|         вшестером, дважды, мало, много, очень, совершенно, трижды, чуть-чуть                 |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  образа и способа действия (каким образом?) —                                                |");
                        Console.WriteLine("|              бегом, вперемешку, вплавь, вхолостую, галопом                                   |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| ОБСТОЯТЕЛЬСТВЕННЫЕ                                                                           |");
                        Console.WriteLine("| 1. места (где? куда?)                                                                        |");
                        Console.WriteLine("| 2. времени (когда? с каких пор?)                                                             |");
                        Console.WriteLine("| 3. причины (почему?)                                                                         |");
                        Console.WriteLine("| 4. цели (зачем?)                                                                             |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  МЕСТОИМЕННЫЕ                                                                                |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  Указательные — здесь, там, тут                                                              |");
                        Console.WriteLine("|  Вопросительно-относительные — где, куда, когда                                              |");
                        Console.WriteLine("|  Неопределённые — где-то, когда-то                                                           |");
                        Console.WriteLine("|  Отрицательные — нигде, никуда                                                               |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 9. В главное меню                                                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadnar();
                    }
                    else if (narnummenu == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                      Правописание НЕ в наречиях                                               |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| НЕ ПИШЕТСЯ СЛИТНО:                                                                           |");
                        Console.WriteLine("| 1. В наречиях, которые без НЕ не употребляются — НЕизбежно, НЕгодующе                        |");
                        Console.WriteLine("| 2.В наречиях на -О, которые можно заменить                                                   |");
                        Console.WriteLine("|                           синонимами без НЕ —НЕвысокО = низко, НЕдалекО = близко             |");
                        Console.WriteLine("| 3. в отрицательных наречиях — НЕгде, НЕкуда                                                  |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| НЕ ПИШЕТСЯ РАЗДЕЛЬНО:                                                                        |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 1. В наречиях на -О при наличии противопоставления с союзом А — НЕ высоко, А низко           |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 2. С наречиями в сравнительной степени — НЕ хуже, НЕ лучше                                   |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 3. с наречиями НЕ на -О — НЕ очень красиво, НЕ совсем хорошо, НЕ здесь, НЕ туда              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 4. со словом ТАК — НЕ ТАК удачно                                                             |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 9. В главное меню                                                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadnar();
                    }
                    else if (narnummenu == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                      Степени сравнения наречий                                               |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 1. Положительная                                                                             |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|   чисто                                                                                      |");
                        Console.WriteLine("|   длинно                                                                                     |");
                        Console.WriteLine("|   красиво                                                                                    |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 2. Сравнительная                                                                             |");
                        Console.WriteLine("|   простая:                                                                                   |");
                        Console.WriteLine("|       чище                                                                                   |");
                        Console.WriteLine("|       красивее                                                                               |");
                        Console.WriteLine("|       длиннее                                                                                |");
                        Console.WriteLine("|   сложная:                                                                                   |");
                        Console.WriteLine("|       более / менее чисто                                                                    |");
                        Console.WriteLine("|       более / менее красиво                                                                  |");
                        Console.WriteLine("|       более / менее длинно                                                                   |");
                        Console.WriteLine("| 3. Превосходная                                                                              |");
                        Console.WriteLine("|     чище всех                                                                                |");
                        Console.WriteLine("|    красивее всех                                                                             |");
                        Console.WriteLine("|     длиннее всех                                                                             |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 9. В главное меню                                                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadnar();
                    }
                    else if (narnummenu == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                      Правописание суффиксов наречий                                          |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| Наречия с приставками В-, НА-, ЗА-                                                           |");
                        Console.WriteLine("|      на конце пишется суффикс -О:                                                            |");
                        Console.WriteLine("|      влевО, насухО, задолгО                                                                  |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 9. В главное меню                                                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadnar();
                    }
                    else if (narnummenu == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                     Степени сравнения наречий                                                |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 9. В главное меню                                                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadnar();
                    }
                }
            else if (nummenu == 6)
            {
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    Console.WriteLine("|                              Частицы                                                         |");
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|   Частица — это служебная часть речи,                                                        |");
                    Console.WriteLine("|     которая придает дополнительные смысловые и                                               |");
                    Console.WriteLine("|         эмоциональные оттенки отдельным словам и                                             |");
                    Console.WriteLine("|           предложениям и служит для образования слов и форм слов.                            |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 1. Разряды частиц                                                                            |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 2. Основные группы смысловых (модальных) частиц                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 3. Отрицательные                                                                             |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 9. В главное меню                                                                            |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    int chastnummenu = Convert.ToInt32(Console.ReadLine());
                    if (chastnummenu == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                              Разряды частиц                                                  |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| Словообразовательные:                                                                        |");
                        Console.WriteLine("|   -то, -либо, -нибудь, кое- образуют                                                         |");
                        Console.WriteLine("|     неопределенные местоимения и наречия от слов этих же частей речи                         |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| Смысловые (модальные)                                                                        |");
                        Console.WriteLine("|  Создают дополнительные оттенки значений у отдельных слов и у всего предложения целиком.     |");
                        Console.WriteLine("|    Они могут выражать восхищение, удивление, сомнение,                                       |");
                        Console.WriteLine("|        уточнение, отрицание и пр. эмоции говорящего.                                         |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| Формообразующие                                                                              |");
                        Console.WriteLine("|  Формообразующие частицы пусть, пускай, да, давай, давайте,                                  |");
                        Console.WriteLine("|    бы (б) употребляются при образовании форм повелительного и условного наклонения глагола.  |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 9. В главное меню                                                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadnar();
                    }
                    else if (chastnummenu == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                       Основные группы смысловых (модальных) частиц                           |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  Отрицательные: Я НЕ герой.                                                                  |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  Вопросительные: Разве я герой?                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  Указательные: Вот герой.                                                                    |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  Уточняющие: Именно я герой.                                                                 |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  Ограничительно-выделительные: Я почти герой.                                                |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  Восклицательные: Я ведь герой!                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  Усилительные: Всё же я герой.                                                               |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  Со значением сомнения: Вряд ли я герой.                                                     |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  Побудительные: Вперед давай и побеждай!                                                     |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  Сравнительные: Я словно герой.                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  Утвердительные: Я правда герой.                                                             |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 9. В главное меню                                                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadnar();
                    }
                    else if (chastnummenu == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                              Отрицательные                                                   |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|  НЕ                                                                                          |");
                        Console.WriteLine("|    Полное отрицание при сказуемом: Ты не слышишь меня.                                       |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|    Частичное — при дру­гих членах предложения: Не вам судить об этом.                         |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|    В устойчивых сочетаниях: едва не, чуть не, вовсе не                                       |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|    При двойном отрицании: Не можем не сообщить об этом                                       |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|  НИ                                                                                          |");
                        Console.WriteLine("|   Усиление при отрица­нии с «не»: Я не скажу больше ни слова.                                 |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|   Усиление утверждения в придаточных с уступи­тельным оттенком:                               |");
                        Console.WriteLine("|                                       Как ни трудно, а выполни это.                          |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 9. В главное меню                                                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadnar();
                    }
                    else if (chastnummenu == 4)
                    {

                    }
                    else if (chastnummenu == 5)
                    {

                    }
                    else if (chastnummenu == 6)
                    {

                    }
                    else if (chastnummenu == 9);
                }
            else if (nummenu == 7)
            {
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    Console.WriteLine("|                              Причастие                                                       |");
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|   Причастие – это самостоятельная часть речи,                                                |");
                    Console.WriteLine("|     которая обозначает проявляющийся во времени признак предмета по действию,                |");
                    Console.WriteLine("|      относится к существительному или местоимению                                            |");
                    Console.WriteLine("|       и отвечает на вопросы какой? какая? какое? какие?                                      |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 1. Залог причастий                                                                           |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 2. Правописание суффиксов причастий                                                          |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 3. Правописание -Н- и -НН- в причастиях                                                      |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 4. Правописание не в причастиях                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 9. В главное меню                                                                            |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    int prichnummenu = Convert.ToInt32(Console.ReadLine());
                    if (prichnummenu == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                              Залог причастий                                                 |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| действительные — обозначают признаки предметов,                                              |");
                        Console.WriteLine("|            которые сами производят действие (ожидающий пассажир).                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| страдательные — образуются только от переходных глаголов и ,                                 |");
                        Console.WriteLine("|  обозначают признаки таких предметов                                                         |");
                        Console.WriteLine("|   над которыми производятся действия (ожидаемый поезд)                                       |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 9. В главное меню                                                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadprich();
                    }
                    else if (prichnummenu == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                              Правописание суффиксов причастий                                |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| Действительные причастия                                                                     |");
                        Console.WriteLine("| -УЩ-, -ЮЩ- пишутся в действительных причастиях настоящего времени,                           |");
                        Console.WriteLine("|               образованных от глаголов I спряжения (колющий, пишущий).                       |");
                        Console.WriteLine("| -АЩ-, -ЯЩ- пишутся в действительных причастиях настоящего времени,                           |");
                        Console.WriteLine("|               образованных от глаголов II спряжения (клеящий, дрожащий).                     |");
                        Console.WriteLine("| -ВШ- пишется в действительных причастиях прошедшего времени                                  |");
                        Console.WriteLine("|                      (образуются от глаголов неопределённой формы) (видевший, слышавший).    |");
                        Console.WriteLine("| -Ш- пишется в действительных причастиях прошедшего времени                                   |");
                        Console.WriteLine("|                    (образуются от глаголов неопределённой формы) (прошедший, выросший).      |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| Страдательные причастия                                                                      |");
                        Console.WriteLine("| -ЕМ-, -ОМ- пишутся в страдательных причастиях настоящего времени,                            |");
                        Console.WriteLine("|             образованных от глаголов I спряжения (увлекаемый, ведомый).                      |");
                        Console.WriteLine("| -ИМ- пишется в страдательных причастиях настоящего времени,                                  |");
                        Console.WriteLine("|    образованных от глаголов II спряжения (видимый,  слышимый).                               |");
                        Console.WriteLine("| -Т- пишется в страдательных причастиях прошедшего времени (понятый, завёрнутый).             |");
                        Console.WriteLine("| -НН- пишется в страдательных причастиях прошедшего времени,                                  |");
                        Console.WriteLine("|   образованных путём добавления -НН- к суффиксам -А-, -Я-                                    |");
                        Console.WriteLine("|     глаголов неопределённой формы (услышанный, развеянный).                                  |");
                        Console.WriteLine("| -ЕНН-, -ЁНН- пишутся в страдательных причастиях прошедшего времени,                          |");
                        Console.WriteLine("|  образованных от глаголов неопределённой формы путём замены суффиксов -ЕТЬ, -ИТЬ             |");
                        Console.WriteLine("|                (обиженный, безветренный, подстреленный).                                     |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 9. В главное меню                                                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadprich();
                    }
                    else if (prichnummenu == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                              Правописание -Н- и -НН- в причастиях                            |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("| -НН- пишется:                                                                                |");
                        Console.WriteLine("| В причастиях совершенного вида (решённая проблема)                                           |");
                        Console.WriteLine("| Если есть приставка (кроме НЕ) (прочитанная книга)                                           |");
                        Console.WriteLine("| Если есть зависимое слово (раненный саблей боец)                                             |");
                        Console.WriteLine("| В причастиях на -ОВАННЫЙ /-ЕВАННЫЙ (маринованные огурцы). Исключения: жёваный, кованый.      |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| -Н- пишется:                                                                                 |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| В кратких причастиях (пицца съедена)                                                         |");
                        Console.WriteLine("| Если нет приставки (крещёный младенец)                                                       |");
                        Console.WriteLine("| Если нет зависимого слова (крашеный пол)                                                     |");
                        Console.WriteLine("| Если есть приставка НЕ- (некрашеный пол).                                                    |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 9. В главное меню                                                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadprich();
                    }
                    else if (prichnummenu == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                              Правописание не в причастиях                                    |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| НЕ пишется СЛИТНО:                                                                           |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| С причастиями, которые без НЕ не употребляются (ненавидимый, негодующий)                     |");
                        Console.WriteLine("| С причастиями, образованными от глаголов с приставкой НЕДО-  (недосчитавшийся)               |");
                        Console.WriteLine("| Если нет зависимых слов или противопоставления (незамеченная ошибка).                        |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| НЕ пишется РАЗДЕЛЬНО:                                                                        |");
                        Console.WriteLine("| При наличии зависимых слов (не замеченная никем ошибка)                                      |");
                        Console.WriteLine("| При наличии противопоставления (не замеченная, а пропущенная ошибка)                         |");
                        Console.WriteLine("| С краткими страдательными причастиями (ошибка не замечена).                                  |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 9. В главное меню                                                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazadprich();
                    }
                    else if (prichnummenu == 9);
                }
            else if (nummenu == 8)
            {
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    Console.WriteLine("|                              Деепричастие                                                    |");
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    Console.WriteLine("|  Деепричастие – это самостоятельная часть речи, совмещает в себе признаки глагола и наречия, |");
                    Console.WriteLine("|    обозначает добавочное действие при основном действии, выраженном глаголом,                |");
                    Console.WriteLine("|                                            отвечает на вопросы что делая? что сделав?        |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|  1. Правописание суффиксов деепричастий                                                      |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|  2. Деепричастный оборот                                                                     |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|  3. Признаки                                                                                 |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("| 9. В главное меню                                                                            |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("|                                                                                              |");
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    int deeprichnummenu = Convert.ToInt32(Console.ReadLine());
                    if (deeprichnummenu == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                             Правописание суффиксов деепричастий                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 9. В главное меню                                                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazaddeeprich();
                    }
                    else if (deeprichnummenu == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                             Деепричастный оборот                                             |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 9. В главное меню                                                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazaddeeprich();
                    }
                    else if (deeprichnummenu == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                      Признаки                                                |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| Вид  — совершенный                                                                           |");
                        Console.WriteLine("|       (от глаголов совершенного вида), несовершенный (от глаголов несовершенного вида)       |");
                        Console.WriteLine("| Переходность — переходные (скрестив руки), непереходные (дойдя до реки);                     |");
                        Console.WriteLine("| Возвратность — от глаголов, которые без -СЯ не употребляются (улыбаясь).                     |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("| 9. В главное меню                                                                            |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("|                                                                                              |");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        nazaddeeprich();
                    }
                    else if (deeprichnummenu == 9)
                    {

                    }
                }
            else if (nummenu == 9)
            {
                Console.WriteLine("тут ничего нет пока что(");
                Thread.Sleep(1000);
            }
            }
            Thread.Sleep(3000);
        }
    }
}