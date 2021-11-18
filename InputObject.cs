using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodyCalculator
{
    public class InputObject
    {
        public int valueOne { get; set; }
        public int valueTwo { get; set; }

        public string resultString(int result, string operatorType) 
        {
            return valueOne.ToString() + " " + operatorType + " " + valueTwo.ToString() + " = " + result.ToString();
        }
    }
}
