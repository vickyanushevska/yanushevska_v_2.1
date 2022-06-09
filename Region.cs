using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба2
{
    enum Regions
    {
        Київська = 1, Львівська, Івано_Франківська, Тернопільська,
        Вінницька, Дніпровська, Харківська, Хмельницька, Рівненська,
        Полтавська, Волинська, Одеська, Чернівецька, Запорізька, Черкаська,
        Кіровоградська, Житомирська, Ужгородська, Кімолаївська, Сумська, Херсонська,
        Чернігівська, Донецька, Луганська, Сімферопольська
    }
    
    internal class Region
    {
        public int NumberOfRegions()
        {
            int number = Enum.GetNames(typeof(Regions)).Length;
            return number;
        }
        public void CallUp()
        {
            Console.WriteLine($"Ви викликали метод Region.");
        }
    }
}