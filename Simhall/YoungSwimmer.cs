using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simhall
{
    class YoungSwimmer:Swimmer
    {
        private bool tired = false;

        public YoungSwimmer(string name, BathingSuit bathingsuit) : base(name, bathingsuit)
        {

        }

        public override void Swim()
        {
            // If kollar efter om tired ar true men om det ar false da anvands else som anvander Swim() och andrar tired till true
            if (tired == true)
            {
                Console.WriteLine("I'm so tired - time to get out");
            }
            else
            {
                base.Swim();
                tired = true;
            }
        }
    }
}
