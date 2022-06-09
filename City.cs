using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба2
{
    enum RegionCentre
    {
        Київ = 1, Львів, Івано_Франківськ, Тернопіль,
        Вінниця, Дніпро, Харків, Хмельницький, Рівне,
        Полтава, Луцьк, Одеса, Чернівці, Запоріжжя, Черкаси,
        Кропивницький, Житомир, Ужгород, Кімолаїв, Суми, Херсон,
        Чернігів, Донецьк, Луганськ, Сімферополь
    }

    class City
    {
        public void Cities()
        {
            foreach (var value in Enum.GetValues(typeof(RegionCentre)))
                Console.WriteLine(value);
        }

        public void Capital()
        {
            Console.WriteLine(RegionCentre.Київ + "--столиця");
        }
        public void CallUp()
        {
            Console.WriteLine("Ви викликали метод City.");
        }
    }
}