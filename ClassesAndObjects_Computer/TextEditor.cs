using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects_Computer
{
    class TextEditor : Applications
    {
        public TextEditor(string applicationName, double requiredRAM, double requiredStorage)
            :base(applicationName, "Text Editor", requiredRAM, requiredStorage)
        {

        }
    }
}
