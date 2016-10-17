using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleClass
{
    [Serializable]
    public class SampleClass
    {

        public string strToUpperCase(string input)
        {
            input = input.ToUpper();
            return input;
        }
    }
}
