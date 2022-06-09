using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба2
{

    class Country
    {
        static void Main(string[] args)
        {


            Region region = new Region();
            region.CallUp();
            Console.Write("кількість областей країни:");
            int number = region.NumberOfRegions();
            Console.Write(number);//кількість областей

            Console.WriteLine();
            Console.WriteLine();

            City city = new City();
            city.CallUp();
            Console.WriteLine("обласні центри країни:");
            city.Cities();//обласні центри

            Console.WriteLine();

            city.Capital();

            District district = new District();
            district.CallUp();
            district.Area = 603548;
            Console.WriteLine($"площа країни: {district.Area} км^2.");
        }

    }
}