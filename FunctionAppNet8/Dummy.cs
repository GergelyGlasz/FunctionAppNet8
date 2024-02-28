using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionAppNet8
{
    public class Dummy
    {
        public void Display(string message)
        {
            System.Diagnostics.Trace.Write(message);
        }
    }
}
