using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MathApi.Models
{
    public class Operation
    {

        public double val1 { get; set; }
        public double val2 { get; set; }
        public string oparator { get; set; }
        public double result { get; set; }

        public Operation(double v1, double v2, string op)
        {
            this.val1 = v1;
            this.val2 = v2;
            this.oparator = op;
            this.result = 0;
        }

        public double process()
        {

            if (oparator.Equals("p"))
            {
                result = val1 + val2;
            }
            else if (oparator.Equals("m"))
            {
                result = val1 - val2;
            }
            else if (oparator.Equals("d"))
            {
                result = val1 / val2;
            }
            else if (oparator.Equals("t"))
            {
                result = val1 * val2;
            }
            else
            {
                result = 0;
            }

            return result;
        }

    }
}