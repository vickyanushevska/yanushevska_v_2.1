using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_extension
{
    public class Place 
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Place(string name, double area)
        {
            Name = name;
            Area = area;
        }

        public override string ToString()
        {
            return Name + " (" + Area + " km^2)";
        }

    }

    class Country 
    {
        District district = new District("t", 45);
        public void main()
        {
            Place ukraine = new Place("Україна", 603700);
            Console.WriteLine(ukraine);
            Place capital = new Place("Київ - столиця", 839);
            Console.WriteLine(capital);
            Console.WriteLine();

            List<District> alldistricts = new List<District>();

            alldistricts.Add(new District("Київська область", 28131));
            alldistricts.Add(new District("Житомирська область", 29830));
            alldistricts.Add(new District("Вiнницька область", 26510));

            Console.WriteLine(alldistricts[0]);
            district.kmain();
            Console.WriteLine(alldistricts[1]);
            district.zhmain();
            Console.WriteLine(alldistricts[2]);
            district.vmain();

            Console.WriteLine("--------------------------------------------------");
            double averagedistrict = alldistricts.Count > 0 ? alldistricts.Average(item => item.Area) : 0.0;
            Console.WriteLine($"Середня площа областi: {averagedistrict} km^2");
        }
    }
}
