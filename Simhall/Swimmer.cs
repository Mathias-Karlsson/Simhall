using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simhall
{
    class Swimmer
    {
        private string name;

        private BathingSuit suit;
        
        public Swimmer(string name)
        {
            this.name = name;
        }

        public Swimmer(string name, BathingSuit bathingsuit)
        {
            this.name = name;
        }

        public virtual void Swim()
        {
            Console.WriteLine("Splish Splash - it's so fun in the bath!");
        }

        public virtual void SetSuit(BathingSuit bs)
        {
            this.suit = bs;
        }
    }
}
