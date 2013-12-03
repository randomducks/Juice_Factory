using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juice_Factory
{
    class OrangeJuiceFactory : JuiceFactory
    {
        public override Juice makeJuice()
        {
            return new OrangeJuice();
        }

        public override JuiceBox makeJuiceBox()
        {
            return new OrangeJuiceBox();
        }
    }
}
