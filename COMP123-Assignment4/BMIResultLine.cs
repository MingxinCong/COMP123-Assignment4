using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Assignment4
{
    class BMIResultLine
    {
        public string Scale;
        public string Result;
        public BMIResultLine(string scale, string result)
        {
            Scale = scale;
            Result = result;
        }

        public override string ToString()
        {
            return $"{ Scale }\t{ Result }";
        }
    }
}
