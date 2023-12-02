﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace TestSP
{
    internal class Press
    {
        private string[] Texts = new string[10];
        private string Tex;
        private int rndint;
        private ConsoleKeyInfo key;
        int i;

        public void Text()
        {
            Texts[0] = "Самый мощный в мире водопад по количеству сбрасываемой воды - Ниагарский - на реке Ниагара в Северной Америке. Его высота составляет 51 метр. А самый высокий в мире водопад (1054 м) - Анхель в Южной Америке, в верховьях реки Чурун. Назван водопад по имени летчика Анхеля, открывшего его в 1935 г.";
            Texts[1] = "В далекой Африке, на реке Замбези, есть настоящее чудо природы - грандиозный водопад Виктория. Его открыл в 1855 г. английский путешественник Давид Ливингстон и назвал в честь английской королевы. Ширина этого водопада составляет 1800 метров, а высота - 120 метров. Шум воды слышен за 25 километров, а еще дальше, километров за 40, видно высокое облако водяной пыли. Радуга играет в брызгах воды, множество ручейков стекает с противоположной водопаду стены каньона, и все новые каскады воды обрушиваются на них, увлекая за собой.";
            Texts[2] = "Многочисленные территориальные споры между различными государствами из-за прохождения границ выглядят достаточно нелепо на фоне новейшего открытия западных ученых, которые установили, что все шесть материков Земли постепенно стягиваются в единое целое. Хотя уже достаточно давно было известно, что гигантские плиты, на которых лежат материки, находятся в движении, однако, согласно опубликованным в Лондоне сенсационным отчетам Университета штата Техас, громадные тектонические силы толкают материки навстречу друг другу.";
            Texts[3] = "Математические модели показывают, что уже в ближайшие 40 млн лет исчезнет Средиземное море. На месте Турции, Италии, Греции и южной Франции образуется горная система, высота которой превзойдет Тибет. В выгодном положении окажется Россия, которая лежит на периферии этих процессов и фактически не пострадает.";
            Texts[4] = "Более сложная судьба ожидает Америку – первоначально она будет отдаляться от Европы и Африки из-за расширения Атлантического океана. Однако затем дно Атлантического океана расколется, его южная часть начнет погружаться в земные глубины. В итоге северная часть Америки будет «присоединена» к юго-западной оконечности Африки, а южная - к Азии в районе Индокитая.";
            Texts[5] = "Санкт-Петербург основан в 1703 году. Санкт-Петербургу 27 мая 2003 года исполнилось 300 лет. На изучение данного материала отводится IV четверть. Статья напечатана в журнале «Наука и жизнь» № 12 за 2002 год. Журнал «Наука и жизнь» издается с октября 1934 года. Книга сдана в набор 29 мая 2003 года, а подписана к печати 24 июня 2003 года. Последняя перепись населения в России проведена в октябре 2002 года. 12 июня 1967 года запущена автоматическая станция Венера-4 для исследования планеты Венера.";
            Random rnd = new Random();
            Tex = Texts[rnd.Next(0, 6)];
            Console.WriteLine(Tex);
        }
        public void Text2(out double min, out double sec)
        {
            Thread Thread = new Thread(Timer);
            Thread.Start();
            Console.SetCursorPosition(0, 0);
            string a = "";
            min = 0;
            sec = 0;
            Console.ForegroundColor = ConsoleColor.Blue;
            for (var s = 0; s < Tex.Length; s++)
            {
                int result;
                do
                {
                    key = Console.ReadKey(true);
                    result = string.Compare(key.KeyChar.ToString(), Tex[s].ToString());
                    if (result == 0)
                    {
                        a = a + key.KeyChar.ToString();
                        Console.SetCursorPosition(0, 0);
                        Console.Write(a);
                        min++;
                    }
                    if (result != 0)
                    {
                        Console.Beep(100, 200);
                    }
                    if (!Thread.IsAlive)
                    {
                        break;
                    }
                }
                while (result != 0);
                if (!Thread.IsAlive)
                {
                    break;
                }
            }
            Console.ResetColor();
            sec = min / 60;
        }
        void Timer()
        {
            for (i = 60;  i > 0; i--) 
            {
                Console.SetCursorPosition(0, 10);
                Console.Write($"Остаток времени: {i} секунд ");
                Thread.Sleep(1000);
            }
            Console.SetCursorPosition(0, 10);
            Console.Write($"Остаток времени: 0 секунд\nТест завершен!!! Нажмите клавишу для продолжения");
        }
    }
}
