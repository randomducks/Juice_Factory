using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juice_Factory
{
    class Client
    {
        public static void Main(string [] args)
        {
            JuiceFactory orangeJuiceFactory = new OrangeJuiceFactory();
            Juice orangeJuice = orangeJuiceFactory.makeJuice();
            JuiceBox orangeJuiceBox = orangeJuiceFactory.makeJuiceBox();

            JuiceFactory grapeJuiceFactory = new GrapeJuiceFactory();
            Juice grapeJuice = grapeJuiceFactory.makeJuice();
            JuiceBox grapeJuiceBox = grapeJuiceFactory.makeJuiceBox();

            Console.ReadKey();
        }
    }
}
