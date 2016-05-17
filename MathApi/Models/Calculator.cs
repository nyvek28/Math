using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MathApi.Models
{
    public class Calculator
    {
        public double operate(Operation op)
        {

            if(op != null)
            {
                return op.process();
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Err");
                return 0;
            }
        }
    }
}