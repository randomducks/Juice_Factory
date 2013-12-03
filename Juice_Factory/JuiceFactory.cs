using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juice_Factory
{
    abstract class JuiceFactory
    {
        /// <summary>
        /// makes juice
        /// </summary>
        /// <returns>an instance of a class based on Juice</returns>
        public abstract Juice makeJuice();

        /// <summary>
        /// makes a juice box
        /// </summary>
        /// <returns>an instance of a class based on JuiceBox</returns>
        public abstract JuiceBox makeJuiceBox();
    }
}