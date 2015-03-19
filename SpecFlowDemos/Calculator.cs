using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowDemos
{
    public class Calculator
    {
        public void Reset()
        {
            Trace.WriteLine("Reset called");
        }

        public int Add(params int[] values)
        {
            return values.Sum();        
        }
    }
}
