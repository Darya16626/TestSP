using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using TestSP;

List<Users> Users = new List<Users>();
string json = File.ReadAllText("C:\\Users\\adv_m\\source\\repos\\TestSP\\TestSP\\Records.json");
Users = JsonConvert.DeserializeObject<List<Users>>(json);
Press Press = new Press();
ConsoleKeyInfo key;
int i = 0;
Users Tester = new Users();
do
{
    if (i == 0)
    {
        Tester = new Users();
        Console.Clear();
        Console.WriteLine("Введите ваше имя");
        Tester.Name = Console.ReadLine();
        i = 1;
    }
    Console.Clear();
    Press.Text();
    Console.WriteLine("---------------------------------------------------------------------");
    Console.WriteLine("Как будете готовы к началу тестирования нажмите Enter");
    Console.WriteLine("Для выхода нажмите Escape");
    key = Console.ReadKey();
    if (key.Key == ConsoleKey.Enter)
    {
        Press.Text2(out double min, out double sec);
        Tester.min = min;
        Tester.sec = sec;
        Users.Add(Tester);
        Users.Sort(delegate (Users y, Users x)
        {
            if (x == null && y == null) return 0;
            else if (x == null) return -1;
            else if (y == null) return 1;
            else
                return x.min.CompareTo(y.min);
        });
        Records.Table(Users);
        i = 0;
    }
}
while (key.Key != ConsoleKey.Escape);