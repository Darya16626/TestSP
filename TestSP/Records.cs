using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace TestSP
{
    internal class Records
    {
        public static void Table(List<Users> Users)
        {
            Console.Clear();
            Console.WriteLine("Таблица рекордов:\n-------------------");
            Console.WriteLine("      Имя          Символов в минуту    Символов в секунду");
            int pos = 4;
            foreach (Users User in Users)
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine($"  {User.Name}");
                Console.SetCursorPosition(15, pos);
                Console.WriteLine($" | {User.min}");
                Console.SetCursorPosition(25, pos);
                Console.WriteLine($" | {User.sec}");
                pos++;
            }
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            ConsoleKeyInfo key = Console.ReadKey(true);
            string json = JsonConvert.SerializeObject(Users);
            File.WriteAllText("C:\\Users\\adv_m\\source\\repos\\TestSP\\TestSP\\Records.json", json);
        }
    }
}
