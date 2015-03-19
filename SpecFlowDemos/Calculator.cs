using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowDemos
{
    public class Calculator
    {
        public int Add(params int[] values)
        {
            return values.Sum();        
        }
    }
}
