using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juice_Factory
{
    class GrapeJuiceFactory : JuiceFactory
    {
        public override Juice makeJuice()
        {
            return new GrapeJuice();
        }

        public override JuiceBox makeJuiceBox()
        {
            return new GrapeJuiceBox();
        }
    }
}
