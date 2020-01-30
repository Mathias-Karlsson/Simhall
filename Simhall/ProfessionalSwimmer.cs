using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simhall
{
    class ProfessionalSwimmer:Swimmer
    {
        public ProfessionalSwimmer(string name, BathingSuit bathingsuit) : base(name, bathingsuit)
        {
            
        }

        public ProfessionalSwimmer(string name) : base(name)
        {

        }
        public override void SetSuit(BathingSuit bs)
        {
            // ProfessionalSwimmer har alltid BathingSuit pa sig
            if (bs != null)
            {
                base.SetSuit(bs);
            }
        }
    }
}
