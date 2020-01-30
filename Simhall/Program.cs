using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simhall
{
    class Program
    {

        static void Main(string[] args)
        {
            SwimmerTest(args);
            Console.ReadKey();
        }
        public static void SwimmerTest(String[] args)
        {
            Swimmer johan = new Swimmer("Johan");
            Swimmer magnus = new Swimmer("Magnus", new BathingSuit());
            johan.SetSuit(new BathingSuit());
            magnus.SetSuit(null);
            ProfessionalSwimmer eric = new ProfessionalSwimmer("Eric", new BathingSuit());
            // Följande rad borde ge kompileringsfel eftersom man
            // inte får skapa ProfSwimmers utan baddräkt!
            ProfessionalSwimmer simon = new ProfessionalSwimmer("Simon");
            // Denna rad borde inte påverka eric alls.
            eric.SetSuit(null);
            List<Swimmer> swimmers = new List<Swimmer>();
            swimmers.Add(johan);
            swimmers.Add(new YoungSwimmer("Christoffer", new BathingSuit()));
            foreach (Swimmer sw in swimmers)
            {
                sw.Swim();
            }
            // Följande kommer ut i terminalen:
            // Splish splash - it's so fun in the bath!
            // Splish splash - it's so fun in the bath!
            foreach (Swimmer sw in swimmers)
            {
                sw.Swim();
            }
            // Följande kommer ut i terminalen:
            // Splish splash - it's so fun in the bath!
            // I'm so tired - time to get out.
        }
    }
}
