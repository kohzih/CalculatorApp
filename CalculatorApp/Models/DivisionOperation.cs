using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Models
{
    internal class DivisionOperation
    {
        public double Execute(double left, double right)
        {
            if (right == 0)
            {
                throw new DivideByZeroException("ゼロで割ることはできません。");
            }
            return left / right;
        }
    }
}
