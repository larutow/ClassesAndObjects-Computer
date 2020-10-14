using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects_Computer
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp1 = new Computer();
            comp1.StartComputer();
            comp1.InstallApps();
        }
    }
}
