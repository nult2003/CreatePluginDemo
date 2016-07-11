using InterfacePlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePluginLib
{
    class Multiply : ICalculate
    {
        public int Operate(int a, int b)
        {
            return (a * b);
        }
    }
}
