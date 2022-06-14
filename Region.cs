using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_extension
{
    class Region : Place
    {
        public Region(string name, double area) : base(name, area){
        }

        public void fmain()
        {
            List<Place> fcities = new List<Place>();
            fcities.Add(new City("\t\tВасилiвка", 0.22));
            fcities.Add(new City("\t\tВишняки", 0.63));

            foreach (var pts in fcities)
            {
                Console.WriteLine(pts.ToString());
            }
        }

        public void bmain()
        {
            List<Place> bcities = new List<Place>();
            bcities.Add(new City("\t\tАртемiвка", 0.62));
            bcities.Add(new City("\t\tАндрiївка", 0.81));

            foreach (var pts in bcities)
            {
                Console.WriteLine(pts.ToString());
            }
        }

        public void bemain()
        {
            List<Place> becities = new List<Place>();
            becities.Add(new City("\t\tБердичiв", 35.33));
            becities.Add(new City("\t\tВишневе", 1.94));

            foreach (var pts in becities)
            {
                Console.WriteLine(pts.ToString());
            }
        }

        public void komain()
        {
            List<Place> kocities = new List<Place>();
            kocities.Add(new City("\t\tКоростень", 42.31));
            kocities.Add(new City("\t\tМихайлiвка", 3.19));

            foreach (var pts in kocities)
            {
                Console.WriteLine(pts.ToString());
            }
        }

        public void zhmmain()
        {
            List<Place> zhmcities = new List<Place>();
            zhmcities.Add(new City("\t\tВасилiвка", 0.36));
            zhmcities.Add(new City("\t\tМогилiвка", 3.6));

            foreach (var pts in zhmcities)
            {
                Console.WriteLine(pts.ToString());
            }
        }

        public void tmain()
        {
            List<Place> tcities = new List<Place>();
            tcities.Add(new City("\t\tТульчин", 9.26));
            tcities.Add(new City("\t\tЮркiвка", 4.15));

            foreach (var pts in tcities)
            {
                Console.WriteLine(pts.ToString());
            }
        }
    }
}
