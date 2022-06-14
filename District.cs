using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_extension
{
    class District : Place
    {
        public District(string name, double area) : base(name, area)
        {
        }

        Region region = new Region("hdj", 7);
        public void kmain()
        {
            List<Region> kregions = new List<Region>();
            kregions.Add(new Region("\tФастiвський район", 1761.2));
            kregions.Add(new Region("\tБориспiльський район", 3873.2));

            Console.WriteLine(kregions[0]);
            region.fmain();
            Console.WriteLine(kregions[1]);
            region.bmain();
            double averageregion1 = kregions.Count > 0 ? kregions.Average(item => item.Area) : 0.0;
            Console.WriteLine($"Середня площа району Київської областi:{averageregion1} km^2");
            Console.WriteLine("--------------------------------------------------");
        }

        public void zhmain()
        {
            List<Region> zhregions = new List<Region>();
            zhregions.Add(new Region("\tБердичiвський район", 3018.5));
            zhregions.Add(new Region("\tКорстенський район", 10892.2));

            Console.WriteLine(zhregions[0]);
            region.bemain();
            Console.WriteLine(zhregions[1]);
            region.komain();
            double averageregion2 = zhregions.Count > 0 ? zhregions.Average(item => item.Area) : 0.0;
            Console.WriteLine($"Середня площа району Житомирської областi:{averageregion2} km^2");
            Console.WriteLine("--------------------------------------------------");
        }

        public void vmain()
        {
            List<Region> vregions = new List<Region>();
            vregions.Add(new Region("\tЖмеринський район", 3136.3));
            vregions.Add(new Region("\tТульчинський район", 3856.3));

            Console.WriteLine(vregions[0]);
            region.zhmmain();
            Console.WriteLine(vregions[1]);
            region.tmain();
            double averageregion3 = vregions.Count > 0 ? vregions.Average(item => item.Area) : 0.0;
            Console.WriteLine($"Середня площа району Вiнницької областi:{averageregion3} km^2");
        }
    }
}
