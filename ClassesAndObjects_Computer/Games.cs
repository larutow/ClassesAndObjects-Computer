using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects_Computer
{
    class Games : Applications
    {
        public double RequiredEffectiveMemory;
        

        public Games(string applicationName, double requiredRAM, double requiredStorage, double RequiredEffectiveMemory)
            : base(applicationName, "Game", requiredRAM, requiredStorage)
        {
            this.RequiredEffectiveMemory = RequiredEffectiveMemory;
            
        }
    }
}
