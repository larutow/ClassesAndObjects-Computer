using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects_Computer
{
    class Messengers : Applications
    {
        public Messengers(string applicationName, double requiredRAM, double requiredStorage)
            :base(applicationName, "Messenger", requiredRAM, requiredStorage)
        {
            
        }
    }
}
