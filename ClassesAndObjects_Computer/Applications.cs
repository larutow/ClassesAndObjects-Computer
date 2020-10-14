using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects_Computer
{
    abstract class Applications
    {
        public string ApplicationName;
        public string ApplicationType;
        public double RequiredRAM;
        public double RequiredStorage;

        public Applications(string applicationName, string applicationType, double requiredRAM, double requiredStorage)
        {
            ApplicationName = applicationName;
            ApplicationType = applicationType;
            RequiredRAM = requiredRAM;
            RequiredStorage = requiredStorage;
        }
    }
}
